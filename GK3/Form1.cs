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
    public partial class Form1 : Form
    {
        DirectBitmap photo;
        public Form1()
        {
            InitializeComponent();
            photo = new DirectBitmap(pictureBox.Width, pictureBox.Height);
            pictureBox.Image = photo.Bitmap;
        }

        void UpdatePhoto(Bitmap b)
        {
            photo = new DirectBitmap(b);
            pictureBox.Image = photo.Bitmap;
            pictureBox.Refresh();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.FilterIndex = 1;
                openFileDialog.InitialDirectory = Application.StartupPath;//.Replace(@"\bin\Debug", @"\Resources");

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    Bitmap bm = new Bitmap(filePath);
                    UpdatePhoto(bm);
                }
            }
        }
    }
}
