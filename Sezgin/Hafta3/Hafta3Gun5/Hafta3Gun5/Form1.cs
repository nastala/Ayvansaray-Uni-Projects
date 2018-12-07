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
        private Random r = new Random();
        private int iAttemps = 0;
        private int x, y;

        public FormCatchMe()
        {
            InitializeComponent();
        }

        private void btnCatchMe_MouseEnter(object sender, EventArgs e)
        {
            x = r.Next(0, this.Size.Width - btnCatchMe.Width);
            y = r.Next(0, this.Size.Height - btnCatchMe.Height);
            if (new Point(x, y) == FormCatchMe.MousePosition)
                btnCatchMe_MouseEnter(sender, e);
            
            btnCatchMe.Location = new Point(x, y);
        }

        private void FormCatchMe_MouseClick(object sender, MouseEventArgs e)
        {
            iAttemps++;
            this.Text = "Total Attemps = " + iAttemps;
        }

        private void btnCatchMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congrats. You're very lucky!");
            this.Text = "Catch Me Game";
            iAttemps = 0;
        }
    }
}
