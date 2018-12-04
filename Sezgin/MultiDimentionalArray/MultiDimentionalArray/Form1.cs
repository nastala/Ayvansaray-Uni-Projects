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
                    int width = bmp.Width;
                    int height = bmp.Height;
                    Bitmap bmpLinedImage = new Bitmap(width, height);
                    Bitmap bmpCrossedImage = new Bitmap(width, height);
                    Bitmap bmpRightAlignedCrossedImage = new Bitmap(width, height);
                    lblFilePath.Text = imagePath;
                    Color[,] twoDimensionalArray = new Color[width, height];
                    string text;
                    lbImagePixels.HorizontalScrollbar = true;
                    int center = width / 2;
                    Color color;
                    float counterLeftAlignedCross = 0;
                    float counterRightAlignedCross = width;
                    float increment = (float)width / (float)height;

                    for (int y = 0; y < height; y++)
                    {
                        text = "";
                        for (int x = 0; x < width; x++)
                        {
                            color = bmp.GetPixel(x, y);
                            if (x <= center && (x + 1) >= center)
                                color = Color.Black;

                            if (x <= counterLeftAlignedCross && (x + 1) >= counterLeftAlignedCross)
                                bmpCrossedImage.SetPixel(x, y, Color.Black);
                            else
                                bmpCrossedImage.SetPixel(x, y, bmp.GetPixel(x, y));

                            if (x <= counterRightAlignedCross && (x + 1) >= counterRightAlignedCross)
                                bmpRightAlignedCrossedImage.SetPixel(x, y, Color.Black);
                            else
                                bmpRightAlignedCrossedImage.SetPixel(x, y, bmp.GetPixel(x, y));

                            bmpLinedImage.SetPixel(x, y, color);
                            twoDimensionalArray[x, y] = color;
                            text += "[" + x + ", " + y + "] -> (" + twoDimensionalArray[x, y].ToString() + "), ";
                        }

                        counterLeftAlignedCross += increment;
                        counterRightAlignedCross -= increment;
                        text = text.Substring(0, text.Length - 2);
                        lbImagePixels.Items.Add(text);
                    }
                    
                    pbPickedImage.Image = bmp;
                    pbCenterLinedPicture.Image = bmpLinedImage;
                    pbCrossedImage.Image = bmpCrossedImage;
                    pbRighAlignedCrossedImage.Image = bmpRightAlignedCrossedImage;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("An error occured! Error message: " + ex.Message);
                }
            }
        }
    }
}
