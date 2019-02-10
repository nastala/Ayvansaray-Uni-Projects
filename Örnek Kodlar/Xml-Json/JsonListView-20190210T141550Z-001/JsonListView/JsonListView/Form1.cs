using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void jsonDosyasıOlusturmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FormJsonOlustur().Show();
            FormJsonOlustur frjson = new FormJsonOlustur();
            frjson.ShowDialog();
        }

        private void jsonDosyasıGörüntülemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormJsonGoruntule().ShowDialog();
        }
    }
}
