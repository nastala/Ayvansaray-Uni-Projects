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
        private Random r;
        private int x, y, width, height, iAttemps;

        public FormCatchMe()
        {
            InitializeComponent();
        }

        private void btnCatchMe_MouseEnter(object sender, EventArgs e)
        {
            x = r.Next(0, width);
            y = r.Next(0, height);
            if (new Point(x, y) == FormCatchMe.MousePosition)
                btnCatchMe_MouseEnter(sender, e);
            
            btnCatchMe.Location = new Point(x, y);
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
