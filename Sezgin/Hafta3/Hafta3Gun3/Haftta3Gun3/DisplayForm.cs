using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Haftta3Gun3
{
    public partial class DisplayForm : Form
    {
        public Font font { get; set; }
        public Color color { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string description { get; set; }

        public DisplayForm()
        {
            InitializeComponent();
        }

        private void fillLabels()
        {
            setLabelProperties();

            lblName.Text = name;
            lblSurname.Text = surname;
            lblDescription.Text = description;
        }

        private void setLabelProperties()
        {
            lblName.Font = font;
            lblSurname.Font = font;
            lblDescription.Font = font;

            lblName.ForeColor = color;
            lblSurname.ForeColor = color;
            lblDescription.ForeColor = color;
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            fillLabels();
        }
    }
}
