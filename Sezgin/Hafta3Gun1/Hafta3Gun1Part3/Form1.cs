using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun1Part3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToLB(string text)
        {
            lbMouseEvents.Items.Add(DateTime.Now + " " + text);
        }

        private void tbText_MouseHover(object sender, EventArgs e)
        {
            SaveToLB("OnMouseHover()");
        }

        private void tbText_MouseLeave(object sender, EventArgs e)
        {
            SaveToLB("OnMouseLeave()");
        }

        private void tbText_MouseEnter(object sender, EventArgs e)
        {
            SaveToLB("OnMouseEnter()");
        }

        private void tbText_MouseDown(object sender, MouseEventArgs e)
        {
            SaveToLB("OnMouseDown()");
        }

        private void tbText_MouseMove(object sender, MouseEventArgs e)
        {
            SaveToLB("OnMouseMove()");
        }

        private void tbText_MouseUp(object sender, MouseEventArgs e)
        {
            SaveToLB("OnMouseUp()");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbMouseEvents.Items.Clear();
        }
    }
}
