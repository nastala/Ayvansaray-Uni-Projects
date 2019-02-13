using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Uygulama_CodeFirst
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void egitimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEgitim frmegtm = new FormEgitim();
            frmegtm.Show();
        }

        private void unvanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnvan frmun = new FormUnvan();
            frmun.Show();
        }

        private void ilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIl frmil = new FormIl();
            frmil.Show();
        }

        private void ilceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIlce frmilce = new FormIlce();
            frmilce.Show();
        }

        private void girişDüzeltmeSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersonel frmpers = new FormPersonel();
            frmpers.Show();
        }
    }
}
