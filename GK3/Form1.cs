using GK3.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK3
{
    enum ModeType
    {
        AddPolygon,
        Brush,
        DeletePolygon,
        TheWholePicture,
    }

    public enum FilterType
    {
        NoFilter,
        Negation,
        BrightnessChange,
        GammaCorrection,
        Contrast,
        OwnFunction
    }

    public partial class Form1 : Form
    {
        ModeType mode;
        FilterType filterType;
        IFilter filter;

        DirectBitmap photo;
        DirectBitmap orginalPicture;
        DirectBitmap transformedPicture;
        Bitmap beforeCreating;

        Edge newEdge;
        Vertex newPoint, startPoint;
        
        List<Polygon> polygons;
        Polygon newPolygon;

        bool isPolygonCreating;
        bool isDrawing;

        public Form1()
        {
            InitializeComponent();
            photo = new DirectBitmap(GK3.Properties.Resources.Lenna);
            orginalPicture = new DirectBitmap(GK3.Properties.Resources.Lenna);
            transformedPicture = new DirectBitmap(GK3.Properties.Resources.Lenna);

            pictureBox.Image = photo.Bitmap;
            polygons = new List<Polygon>();

            isPolygonCreating = false;
            isDrawing = false;
            setMode(ModeType.AddPolygon);
            filterType = FilterType.NoFilter;

            filter = new NegationFilter();
            IFilter brightness = new BrightnessChangeFilter();
            IFilter contrast = new ContrastFilter();
            IFilter gammaCorrection = new GammaCorrectionFilter();


            filter.setNext(brightness);
            brightness.setNext(contrast);
            contrast.setNext(gammaCorrection);

            histR.Series[0].Color = Color.Red;
            histG.Series[0].Color = Color.Green;
            histB.Series[0].Color = Color.Blue;

            UpdatePhoto();
        }

        void LoadPhoto(Bitmap b)
        {
            photo.Dispose();
            orginalPicture.Dispose();
            transformedPicture.Dispose();

            photo = new DirectBitmap(b);
            orginalPicture = new DirectBitmap(b);
            transformedPicture = new DirectBitmap(b);

            pictureBox.Image = photo.Bitmap;
            polygons.Clear();
            UpdatePhoto();
        }

        void UpdatePhoto()
        {
            using(Graphics g = Graphics.FromImage(photo.Bitmap))
            {
                g.DrawImage(transformedPicture.Bitmap, 0, 0);
            }
            foreach (var poly in polygons)
            {
                if (poly.isValid)
                    poly.Fill(photo, transformedPicture);
                poly.Draw(photo);
            }

            var data = CreateHistogramR();
            DrawHistogramR(data);
                
            pictureBox.Invalidate();
        }

        void UpdatePolygon()
        {
            using (Graphics g = Graphics.FromImage(photo.Bitmap))
            {
                g.DrawImage(beforeCreating, 0, 0);
            }
            newPolygon.Draw(photo);
            pictureBox.Invalidate();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.InitialDirectory = Application.StartupPath.Replace(@"\bin\Debug", @"\Resources");

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Bitmap picture = new Bitmap(filePath);
                    LoadPhoto(picture);
                }
            }
        }

        (int[] R,int[] G,int[] B) CreateHistogramR()
        {
            int[] dataR = new int[256];
            int[] dataG = new int[256];
            int[] dataB = new int[256];
            int width = photo.Width;
            int height = photo.Height;

            for(int i=0;i<height;i++)
            {
                for(int j=0;j<width;j++)
                {
                    Color col = photo.GetPixel(j, i);
                    dataR[col.R]++;
                    dataG[col.G]++;
                    dataB[col.B]++;
                }
            }
            return (dataR, dataB, dataG);
        }

        void DrawHistogramR((int[] R, int[] B, int[] G) k)
        {
            histR.Series[0].Points.DataBindY(k.R);
            histG.Series[0].Points.DataBindY(k.G);
            histB.Series[0].Points.DataBindY(k.B);
        }

        void DrawBrush(Point p)
        {
            Elipse elipse = new Elipse();
            elipse.Fill(photo, transformedPicture, filter, p.X, p.Y);
            UpdatePhoto();
        }
        #region MainPicturebox handlers
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(isPolygonCreating)
            {
                newPoint.X = e.Location.X;
                newPoint.Y = e.Location.Y;
                UpdatePolygon();
            }
            if(isDrawing)
            {
                DrawBrush(e.Location);
                UpdatePhoto();
            }

        }

        Polygon FindClosestPoly(Point p)
        {
            double min = double.MaxValue;
            Polygon closestPoly = null;
            foreach(Polygon poly in polygons)
            {
                double tmp = poly.DistanceFromPoint(p);
                if(tmp < min)
                {
                    min = tmp;
                    closestPoly = poly;
                }
            }
            return closestPoly;
        }

        void DeletePolygon(Point p)
        {
            Polygon poly = FindClosestPoly(p);
            if(poly != null)
            {
                polygons.Remove(poly);
                UpdatePhoto();
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (orginalPicture == null)
            {
                MessageBox.Show("Load picture first", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                switch (mode)
                {
                    case ModeType.AddPolygon:
                        if (!isPolygonCreating)
                        {
                            isPolygonCreating = true;
                            startPoint = e.Location;
                            newPoint = e.Location;
                            beforeCreating = new Bitmap(photo.Bitmap);
                            newEdge = new Edge(startPoint, newPoint);
                            newPolygon = new Polygon(newEdge);
                            newPolygon.setFilter(filter);
                            newPolygon.setFilterType(filterType);
                            polygons.Add(newPolygon);
                        }
                        else
                        {
                            if (Math.Abs(e.Location.X - startPoint.X) < 20
                                && Math.Abs(e.Location.Y - startPoint.Y) < 20 && newPolygon.Count() > 2)
                            {
                                newEdge.B = startPoint;
                                newPolygon.isValid = true;
                                isPolygonCreating = false;
                            }
                            else
                            {
                                Vertex v = e.Location;
                                newEdge = new Edge(newPoint, v);
                                newPolygon.AddEdge(newEdge);
                                newPoint = v;
                            }
                        }
                        UpdatePhoto();
                        break;
                    case ModeType.DeletePolygon:
                        DeletePolygon(e.Location);
                        break;
                    case ModeType.Brush:
                        isDrawing = true;
                        DrawBrush(e.Location);
                        break;
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
                isDrawing = false;
        }
        #endregion


        #region Button handlers
        private void radioButtonNegation_Click(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            btn.Checked = true;
            filterType = FilterType.Negation;
        }
        private void radioButtonNoFilter_Click(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            btn.Checked = true;
            filterType = FilterType.NoFilter;
        }
        private void radioButtonBrightness_Click(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            btn.Checked = true;
            filterType = FilterType.BrightnessChange;
        }
        private void radioButtonGamma_Click(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            btn.Checked = true;
            filterType = FilterType.GammaCorrection;
        }
        private void radioButtonContrast_Click(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            btn.Checked = true;
            filterType = FilterType.Contrast;
        }

        void setMode(ModeType modeType)
        {
            if (isPolygonCreating) return;
            mode = modeType;
            labelMode.Text = mode.ToString();
        }
        private void buttonAddPolygon_Click(object sender, EventArgs e)
        {
            setMode(ModeType.AddPolygon);
        }
        private void buttonDeletePolygon_Click(object sender, EventArgs e)
        {
            setMode(ModeType.DeletePolygon);
        }
        private void buttonBrush_Click(object sender, EventArgs e)
        {
            setMode(ModeType.Brush);
        }
        private void buttonWholePicture_Click(object sender, EventArgs e)
        {
            setMode(ModeType.TheWholePicture);
            FilterOnWholePhoto();
        }
        private void radioButtonOwn_Click(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            btn.Checked = true;
            filterType = FilterType.OwnFunction;
        }
        #endregion

        void FilterOnWholePhoto()
        {
            using(Graphics g = Graphics.FromImage(photo.Bitmap))
            {
                int width = photo.Width;
                int height = photo.Height;
                polygons.Clear();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Color col = filter.Handle(filterType, orginalPicture, j, i);
                        transformedPicture.SetPixel(j, i, col);
                    }
                }
                UpdatePhoto();
            }
        }

        
    }
}
