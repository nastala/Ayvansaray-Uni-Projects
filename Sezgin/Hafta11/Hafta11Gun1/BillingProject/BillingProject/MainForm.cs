using BillingProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void addCityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageCitiesForm manageCitiesForm = new ManageCitiesForm();
            manageCitiesForm.ShowDialog();
        }

        private void addDistrictToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDistrictsForm manageDistrictsForm = new ManageDistrictsForm();
            manageDistrictsForm.ShowDialog();
        }
    }
}
