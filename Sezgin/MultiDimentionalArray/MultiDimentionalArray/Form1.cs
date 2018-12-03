using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiDimentionalArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImageOpen_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                try
                {
                    Bitmap bmp = new Bitmap(imagePath);
                    lblFilePath.Text = imagePath;
                    string[,] twoDimentionalArray = new string[bmp.Height, bmp.Width];
                    string text;
                    lbImagePixels.HorizontalScrollbar = true;

                    for (int i = 0; i < bmp.Height; i++)
                    {
                        text = "";
                        for (int j = 0; j < bmp.Width; j++)
                        {
                            twoDimentionalArray[i, j] = "R:" + bmp.GetPixel(i, j).R + ", G:" + bmp.GetPixel(i, j).G + ", B:" + bmp.GetPixel(i, j).B;
                            text += "[" + i + ", " + j + "] -> (" + twoDimentionalArray[i, j] + "), ";
                        }
                        text = text.Substring(0, text.Length - 2);
                        lbImagePixels.Items.Add(text);
                    }

                    pbImage.Image = bmp;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error occured! Error message: " + ex.Message);
                }
            }
        }
    }
}
