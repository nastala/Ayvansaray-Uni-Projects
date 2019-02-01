using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1.Forms.AdminForms
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            AddBusForm addBusForm = new AddBusForm();
            addBusForm.Show();
        }
    }
}
