using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun5
{
    public partial class FormCatchMe : Form
    {
        //Hafta 3, Gün 5, Part 1 <-----> 07.12.2018

        private Random r;
        private int xNew, yNew, width, height, iAttemps, prevX, prevY, bWidth, bHeight, xNewR, yNewR, prevXR, prevYR;

        public FormCatchMe()
        {
            InitializeComponent();
        }

        private void btnCatchMe_MouseEnter(object sender, EventArgs e)
        {
            xNew = r.Next(0, width);
            yNew = r.Next(0, height);
            xNewR = xNew + bWidth;
            yNewR = yNew + bHeight;
            prevXR = prevX + bWidth;
            prevYR = prevY + bHeight;

            if(((xNew >= prevX && xNew <= prevXR) || (xNewR >= prevX && xNewR <= prevXR)) && 
                (yNew >= prevY && yNew <= prevYR) || (yNewR >= prevY && yNewR <= prevYR))
            {
                btnCatchMe_MouseEnter(sender, e);
                return;
            }

            //if ((x <= prevX && (prevX + bWidth) >= x) && (y <= prevY && (prevY + bHeight) >= y))
            //{
            //    btnCatchMe_MouseEnter(sender, e);
            //    return;
            //}

            prevX = xNew;
            prevY = yNew;
            btnCatchMe.Location = new Point(xNew, yNew);
        }

        private void FormCatchMe_MouseClick(object sender, MouseEventArgs e)
        {
            iAttemps++;
            this.Text = "Total Attemps = " + iAttemps;
        }

        private void FormCatchMe_Load(object sender, EventArgs e)
        {
            width = this.Size.Width - btnCatchMe.Width * 2;
            height = this.Size.Height - btnCatchMe.Height * 2;
            bWidth = btnCatchMe.Width;
            bHeight = btnCatchMe.Height;
            btnCatchMe.Location = new Point((this.Size.Width / 2) - (bWidth / 2) , (this.Size.Height / 2) - (bHeight / 2));
            iAttemps = 0;
            r = new Random();
        }

        private void btnCatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats. You're very lucky!");
            this.Text = "Catch Me Game";
            iAttemps = 0;
        }
    }
}
