using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drag_Drop
{
    public partial class Additions : Form
    {
        public bool IsOn { get; set; }
        public Additions()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            using (var additionForm = new EditAddition())
            {
                if (additionForm.ShowDialog() == DialogResult.OK)
                {
                    lBAdditions.Items.Add(additionForm.Addition);
                }
            }
        }

        private void Additions_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsOn = false;
            this.Hide();
            e.Cancel = true;
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            if (lBAdditions.SelectedIndex != -1)
            {
                using (var additionForm = new EditAddition((Addition)lBAdditions.SelectedItem))
                {
                    if (additionForm.ShowDialog() == DialogResult.OK)
                    {
                        lBAdditions.Items[lBAdditions.SelectedIndex] = additionForm.Addition;
                    }
                }
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (lBAdditions.SelectedIndex != -1)
            {
                lBAdditions.Items.RemoveAt(lBAdditions.SelectedIndex);
            }
        }

        private void Additions_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lBAdditions.SelectedIndex != -1)
                {
                    lBAdditions.DoDragDrop(lBAdditions.SelectedItem, DragDropEffects.Link);
                }
            }
        }

        private void Additions_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }
    }
}
