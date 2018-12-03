using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hafta3Gun1Part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) 
                && !char.IsSeparator(e.KeyChar);
        }

        private void tbDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tbUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbUpper.CharacterCasing = CharacterCasing.Upper;
        }

        private void tbLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbLower.CharacterCasing = CharacterCasing.Lower;
        }
    }
}
