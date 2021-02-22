using GK3.Filters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK3
{
    public partial class Form1 : Form
    {
        const int OWN_FUNCTION_POINTS = 10;
        ModeType mode;
        FilterType filterType;
        IFilter filter;

        BrightnessChangeFilter brightnessFilter;
        GammaCorrectionFilter gammaFilter;
        ContrastFilter contrastFilter;
        OwnFunctionFilter ownFunctionFilter;

        DirectBitmap photo;
        DirectBitmap orginalPicture;
        DirectBitmap transformedPicture;
        DirectBitmap ownFunctionPicture;
        Bitmap beforeCreating;

        Edge newEdge;
        Vertex newPoint, startPoint;

        List<Polygon> polygons;
        Polygon newPolygon;

        bool isPolygonCreating;
        bool isDrawing;
        Vertex[] ownFunction;

        public Form1()
        {
            InitializeComponent();
            photo = new DirectBitmap(GK3.Properties.Resources.Lenna);
            orginalPicture = new DirectBitmap(GK3.Properties.Resources.Lenna);
            transformedPicture = new DirectBitmap(GK3.Properties.Resources.Lenna);
            ownFunctionPicture = new DirectBitmap(300, 300);

            pictureBox.Image = photo.Bitmap;
            pictureBoxOwnFunction.Image = ownFunctionPicture.Bitmap;
            polygons = new List<Polygon>();

            isPolygonCreating = false;
            isDrawing = false;
            ownFunction = new Vertex[OWN_FUNCTION_POINTS];
            FillFunction(ownFunction);

            setMode(ModeType.AddPolygon);
            filterType = FilterType.NoFilter;

            filter = new NegationFilter();
            brightnessFilter = new BrightnessChangeFilter();
            contrastFilter = new ContrastFilter();
            gammaFilter = new GammaCorrectionFilter();
            ownFunctionFilter = new OwnFunctionFilter(ownFunction);

            filter.setNext(brightnessFilter);
            brightnessFilter.setNext(contrastFilter);
            contrastFilter.setNext(gammaFilter);
            gammaFilter.setNext(ownFunctionFilter);

            histR.Series[0].Color = Color.Red;
            histG.Series[0].Color = Color.Green;
            histB.Series[0].Color = Color.Blue;

            DrawOwnFunctionAxis();
            DrawOwnFunction();
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
            using (Graphics g = Graphics.FromImage(photo.Bitmap))
            {
                g.DrawImage(transformedPicture.Bitmap, 0, 0);
            }
            foreach (var poly in polygons)
            {
                if (poly.isValid)
                    poly.Fill(photo, transformedPicture);
                poly.Draw(photo);
            }

            if (!isDrawing)
            {
                var data = CreateHistogram();
                DrawHistogram(data);
            }

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

        void UpdateOwnFunction()
        {
            using (Graphics g = Graphics.FromImage(ownFunctionPicture.Bitmap))
            {
                g.Clear(Color.White);
            }
            DrawOwnFunctionAxis();
            DrawOwnFunction();
            pictureBoxOwnFunction.Invalidate();
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

        (int X, int Y) FromPlotToPicturebox(Vertex v)
        {
            (int X, int Y) k;
            k.X = (int)(v.X / 1.7) + 20;
            k.Y = 170 - (int)(v.Y / 1.7);
            return k;

        }
        (int[] R, int[] G, int[] B) CreateHistogram()
        {
            int[] dataR = new int[256];
            int[] dataG = new int[256];
            int[] dataB = new int[256];
            int width = photo.Width;
            int height = photo.Height;

            Parallel.For(0, height, (i) =>
             {
                 for (int j = 0; j < width; j++)
                 {
                     Color col = photo.GetPixel(j, i);
                     dataR[col.R]++;
                     dataG[col.G]++;
                     dataB[col.B]++;
                 }
             });
            return (dataR, dataG, dataB);
        }
        void DrawHistogram((int[] R, int[] G, int[] B) k)
        {
            histR.Series[0].Points.DataBindY(k.R);
            histG.Series[0].Points.DataBindY(k.G);
            histB.Series[0].Points.DataBindY(k.B);
        }

        void DrawBrush(Point p)
        {
            if (p.X < 0 || p.Y < 0 || p.X >= pictureBox.Width || p.Y >= pictureBox.Height) return;
            CircularBrush.Fill(transformedPicture, orginalPicture, filter, filterType, p.X, p.Y);
            UpdatePhoto();
        }

        void FilterOnWholePhoto()
        {
            using (Graphics g = Graphics.FromImage(photo.Bitmap))
            {
                int width = photo.Width;
                int height = photo.Height;
                polygons.Clear();

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        Color color = orginalPicture.GetPixel(j, i);
                        Color col = filter.Handle(filterType, color);
                        transformedPicture.SetPixel(j, i, col);
                    }
                }
                UpdatePhoto();
            }
        }

        #region MainPicturebox handlers
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPolygonCreating)
            {
                newPoint.X = e.Location.X;
                newPoint.Y = e.Location.Y;
                UpdatePolygon();
            }
            if (isDrawing)
            {
                DrawBrush(e.Location);
            }
        }

        Polygon FindClosestPoly(Point p)
        {
            double min = double.MaxValue;
            Polygon closestPoly = null;
            foreach (Polygon poly in polygons)
            {
                double tmp = poly.DistanceFromPoint(p);
                if (tmp < min)
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
            if (poly != null)
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
            {
                isDrawing = false;
                var data = CreateHistogram();
                DrawHistogram(data);
            }
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

        #region OwnFunction

        bool dragVertex = false;
        Vertex movingVertex;
        int vertexNr;
        private void pictureBoxOwnFunction_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (!dragVertex)
                {
                    movingVertex = FindVertex(e.Location);
                    if (movingVertex != null)
                        dragVertex = true;
                }
            }
        }
        private void pictureBoxOwnFunction_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragVertex)
            {
                var k = FromPlotToPicturebox(ownFunction[vertexNr - 1]);
                var k2 = FromPlotToPicturebox(ownFunction[vertexNr + 1]);
                if (e.Location.X > k.X && e.Location.X < k2.X
                    && e.Location.Y >= 20 && e.Location.Y <= 170)
                {
                    movingVertex.X = (int)((e.Location.X - 20) * 1.7);
                    movingVertex.Y = (int)((170 - e.Location.Y) * 1.7);
                    DrawOwnFunction();
                }
            }
        }
        private void pictureBoxOwnFunction_MouseUp(object sender, MouseEventArgs e)
        {
            if (dragVertex)
                dragVertex = false;
        }

        Vertex FindVertex(Point p)
        {
            for (int i = 1; i < ownFunction.Length - 1; i++)
            {
                var k = FromPlotToPicturebox(ownFunction[i]);

                double dist = Math.Sqrt((k.X - p.X) * (k.X - p.X) + (k.Y - p.Y) * (k.Y - p.Y));
                if (dist < 5)
                {
                    vertexNr = i;
                    return ownFunction[i];
                }
            }
            return null;
        }
        void DrawOwnFunction()
        {
            using (Graphics g = Graphics.FromImage(pictureBoxOwnFunction.Image))
            {
                g.Clear(Color.White);
                DrawOwnFunctionAxis();
                int x1, y1;
                x1 = y1 = 0;
                for (int i = 0; i < ownFunction.Length; i++)
                {
                    var k = FromPlotToPicturebox(ownFunction[i]);

                    g.FillEllipse(Brushes.Black, k.X - 3, k.Y - 3, 6, 6);
                    if (i != 0)
                    {
                        g.DrawLine(Pens.Black, x1, y1, k.X, k.Y);
                    }
                    x1 = k.X;
                    y1 = k.Y;
                }
            }
            pictureBoxOwnFunction.Invalidate();
        }
        void FillFunction(Vertex[] ownF)
        {
            ownF[0] = new Vertex(0, 0);
            ownF[ownF.Length - 1] = new Vertex(255, 255);

            Random rnd = new Random(2137);
            for (int i = 1; i < ownF.Length - 1; i++)
            {
                ownF[i] = new Vertex(i * 26, rnd.Next(0, 256));
            }
        }
        void DrawOwnFunctionAxis()
        {
            using (Graphics g = Graphics.FromImage(pictureBoxOwnFunction.Image))
            {
                Font myFont = new Font("Arial", 8);
                g.DrawLine(Pens.Black, 20, 20, 20, 170);
                g.DrawLine(Pens.Black, 20, 170, 200, 170);
                g.DrawString("255", myFont, Brushes.Black, 0, 20);
                g.DrawString("0", myFont, Brushes.Black, 10, 170);
                g.DrawString("255", myFont, Brushes.Black, 170, 170);
            }
        }
        #endregion

        #region Change Constant In Filters
        private void BrightnessSub_Click(object sender, EventArgs e)
        {
            brightnessFilter.Sub();
        }

        private void BrightnessAdd_Click(object sender, EventArgs e)
        {
            brightnessFilter.Add();
        }

        private void gammaSub_Click(object sender, EventArgs e)
        {
            gammaFilter.Sub();
        }

        private void gammaAdd_Click(object sender, EventArgs e)
        {
            gammaFilter.Add();
        }

        private void contrastSub_Click(object sender, EventArgs e)
        {
            contrastFilter.Sub();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ownfunction.dat", FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, ownFunction);
            MessageBox.Show("Own function saved", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ownfunction.dat", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Vertex[] tmp;
            try
            {
                tmp = (Vertex[])formatter.Deserialize(fs);
                ownFunction = tmp;
            }
            catch(Exception)
            {
                MessageBox.Show("Error when deserializing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            fs.Close();
            ownFunctionFilter.ChangeFunction(ownFunction);
            UpdateOwnFunction();
            MessageBox.Show("Own function loaded", "Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contrastAdd_Click(object sender, EventArgs e)
        {
            contrastFilter.Add();
        }

        #endregion

    }
}
