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
                lbImagePixels.Items.Clear();
                string imagePath = openFileDialog1.FileName;
                try
                {
                    Bitmap bmp = new Bitmap(imagePath);
                    lblFilePath.Text = imagePath;
                    Color[,] twoDimensionalArray = new Color[bmp.Width, bmp.Height];
                    string text;
                    lbImagePixels.HorizontalScrollbar = true;

                    for (int y = 0; y < bmp.Height; y++)
                    {
                        text = "";
                        for (int x = 0; x < bmp.Width; x++)
                        {
                            twoDimensionalArray[x, y] = bmp.GetPixel(x,y);
                            text += "[" + x + ", " + y + "] -> (" + twoDimensionalArray[x, y].ToString() + "), ";
                        }
                        text = text.Substring(0, text.Length - 2);
                        lbImagePixels.Items.Add(text);
                    }
                    
                    pbImage.Image = bmp;

                    //Bitmap bmp2 = new Bitmap(bmp.Width, bmp.Height, bmp.Width * 4, System.Drawing.Imaging.PixelFormat.Format32bppRgb);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error occured! Error message: " + ex.Message);
                }
            }
        }
    }
}
