using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class FormFirstInput : Form
    {
        public FormFirstInput()
        {
            InitializeComponent();
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (tBFirstLetter.TextLength == 1)
            {
                DialogResult = DialogResult.OK;
            }
        }
        public char ShowDialogWindow()
        {
            this.ShowDialog();
            if (tBFirstLetter.TextLength == 1)
            {
                return tBFirstLetter.Text[0];
            }
            return '\0';
        }
    }
}
