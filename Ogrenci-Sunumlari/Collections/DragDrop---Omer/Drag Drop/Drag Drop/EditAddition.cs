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
    public partial class EditAddition : Form
    {
        private Addition _addition;
        public Addition Addition => _addition;
        public EditAddition(Addition addition = null)
        {
            InitializeComponent();
            if (addition != null)
            {
                tBName.Text = addition.Name;
                tBPrice.Text = addition.Price.ToString();
            }
        }

        private void BPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                int dotIndex = tBPrice.Text.IndexOf('.');
                if (char.IsDigit(e.KeyChar))
                {
                    if (dotIndex != -1 &&
                        dotIndex < tBPrice.SelectionStart &&
                        tBPrice.Text.Substring(dotIndex + 1).Length >= 2)
                    {
                        e.Handled = true;
                    }
                }
                else
                    e.Handled = e.KeyChar != '.' || dotIndex != -1 ||
                                tBPrice.Text.Length == 0 ||
                                tBPrice.SelectionStart + 2 < tBPrice.Text.Length;
            }
        }

        private void EditAddition_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(tBName.Text) || string.IsNullOrEmpty(tBPrice.Text))
                {
                    MessageBox.Show("Fields can not be empty."); return;
                }
                else
                {
                    if(_addition == null) _addition = new Addition();
                    _addition.Name = tBName.Text;
                    _addition.Price = float.Parse(tBPrice.Text);
                    DialogResult = DialogResult.OK;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Abort;
            }
        }
    }
}
