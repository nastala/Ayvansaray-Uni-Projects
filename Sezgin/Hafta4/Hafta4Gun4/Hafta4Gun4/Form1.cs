using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta4Gun4
{
    public partial class Form1 : Form
    {
        private int totalTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVibrate_Click(object sender, EventArgs e)
        {
            if(!timer1.Enabled)
                timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbDiceLeft.Image = ilDiceNumbers.Images[0];
            pbDiceRight.Image = ilDiceNumbers.Images[0];
            totalTime = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            totalTime += timer1.Interval;
            if(totalTime >= 2000)
            {
                timer1.Stop();
                totalTime = 0;
                btnVibrate.Location = new Point(80, 120);
                Random r = new Random();
                pbDiceLeft.Image = ilDiceNumbers.Images[r.Next(1, 7) - 1];
                pbDiceRight.Image = ilDiceNumbers.Images[r.Next(1, 7) - 1];
            }
            else
            {
                if ((totalTime / timer1.Interval) % 2 == 0)
                    btnVibrate.Location = new Point(60, 120);
                else
                    btnVibrate.Location = new Point(100, 120);
            }
        }
    }
}
