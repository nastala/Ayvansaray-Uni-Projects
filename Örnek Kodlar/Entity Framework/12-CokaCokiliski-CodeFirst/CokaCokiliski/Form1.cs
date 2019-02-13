using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CokaCokiliski
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ogrenciToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormOgrenci frm = new FormOgrenci();
            frm.Show();
        }

        private void egitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEgitmen frm = new FormEgitmen();
            frm.Show();
        }

        private void ogrenciEgitmenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIliski frm = new FormIliski();
            frm.Show(); 
        }
    }
}
