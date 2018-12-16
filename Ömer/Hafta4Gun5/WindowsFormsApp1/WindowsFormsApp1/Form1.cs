using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private readonly TabController _tabController;
       
        public Form1()
        {
            InitializeComponent();
            _tabController = new TabController(tCMain);
            _tabController.AddTabPage();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            _tabController.AddTabPage();
        }

        private void tCMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.Graphics.DrawString("X", e.Font, Brushes.Red, e.Bounds.Right - 15, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tCMain.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 3, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tCMain_MouseDown(object sender, MouseEventArgs e)
        {
            _tabController.RemovePage(e);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            _tabController.Save();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            _tabController.OpenText();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tabController.Save(true);
        }
    }
}
