using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumSample
{
    public partial class Fruit : Form
    {
        private List<CustomClass> fruits;

        public Fruit()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fruits = new List<CustomClass>();
            fruits.Add(new CustomClass("Apple", CustomClass.Fruit.Apple));
            fruits.Add(new CustomClass("Apricot", CustomClass.Fruit.Apricot));
            fruits.Add(new CustomClass("Blackberry", CustomClass.Fruit.Blackberry));
            fruits.Add(new CustomClass("Peach", CustomClass.Fruit.Peach));
            fruits.Add(new CustomClass("Banana", CustomClass.Fruit.Banana));
            fruits.Add(new CustomClass("Orange", CustomClass.Fruit.Orange));

            string imagePath = @"C:\Users\iau\Documents\GitHub\Ayvansaray-Uni-Projects\Sezgin\EnumSample\Images\";
            string extension;
            foreach(CustomClass fruit in fruits)
            {
                extension = "";

                //switch (fruit.Image)
                //{
                //    case CustomClass.Fruit.Apple:
                //        extension += "apple";
                //        break;
                //    case CustomClass.Fruit.Apricot:
                //        extension += "apricot";
                //        break;
                //    case CustomClass.Fruit.Blackberry:
                //        extension += "blackberry";
                //        break;
                //    case CustomClass.Fruit.Banana:
                //        extension += "banana";
                //        break;
                //    case CustomClass.Fruit.Peach:
                //        extension += "peach";
                //        break;
                //    case CustomClass.Fruit.Orange:
                //        extension += "orange";
                //        break;
                //}
                extension += ((CustomClass.Fruit)fruit.Image).ToString().ToLower();
                extension += ".png";

                flpFruitsCreateControl(fruit.ImageName, imagePath + extension);
            }
        }

        private void flpFruitsCreateControl(string imageName, string imagePath)
        {
            Panel panel = new Panel();
            panel.Parent = flpFruits;
            panel.Size = new Size(110, 140);

            Label lblImageName = new Label();
            lblImageName.Size = new Size(60, 20);
            lblImageName.Location = new Point(30, 5);
            lblImageName.TextAlign = ContentAlignment.MiddleCenter;
            lblImageName.Text = imageName;

            PictureBox pbImage = new PictureBox();
            pbImage.Size = new Size(100, 100);
            pbImage.Location = new Point(5, 30);
            pbImage.ImageLocation = imagePath;

            panel.Controls.Add(lblImageName);
            panel.Controls.Add(pbImage);
            flpFruits.Controls.Add(panel);
        }
    }

    public class CustomClass
    {
        public enum Fruit
        {
            Apple,
            Blackberry,
            Banana,
            Peach,
            Apricot,
            Orange
        }

        public Fruit Image { get; }
        public string ImageName { get; }

        public CustomClass(string ImageName, Fruit Image)
        {
            this.Image = Image;
            this.ImageName = ImageName;
        }
    }
}
