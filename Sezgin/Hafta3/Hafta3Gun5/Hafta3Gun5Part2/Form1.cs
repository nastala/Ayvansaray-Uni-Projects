using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun5Part2
{
    public partial class Form1 : Form
    {
        //Hafta 3, Gün 5, Part 2 - Koşu Yarışı <-----> 07.12.2018
        private Random r;
        private int width, horseX, sonicX;
        private string winner;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initializeVars();
            timer1.Start();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            initializeVars();
            btnAgain.Visible = false;
            timer1.Start();
        }

        private void initializeVars()
        {
            r = new Random();
            width = this.Size.Width - (pbHorse.Width * 2);
            pbHorse.Location = new Point(13, 13);
            pbSonic.Location = new Point(13, 69);
            winner = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            horseX = pbHorse.Location.X + r.Next(0, 16);
            sonicX = pbSonic.Location.X + r.Next(0, 16);

            if(horseX >= width)
            {
                horseX = width;
                winner += "Horse";
            }

            if(sonicX >= width)
            {
                horseX = width;
                winner += "Sonic";
            }

            pbHorse.Location = new Point(horseX, pbHorse.Location.Y);
            pbSonic.Location = new Point(sonicX, pbSonic.Location.Y);

            if (!string.IsNullOrEmpty(winner))
            {
                timer1.Stop();
                if (winner.Contains("Horse") && winner.Contains("Sonic"))
                    MessageBox.Show("Draw!");
                else
                    MessageBox.Show(winner + " won!");
                btnAgain.Visible = true;
            }
        }
    }
}
