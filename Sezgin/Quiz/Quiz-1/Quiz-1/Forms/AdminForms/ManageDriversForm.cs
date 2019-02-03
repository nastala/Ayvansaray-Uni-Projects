using Quiz_1.Classes;
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
    public partial class ManageDriversForm : Form
    {
        private Model _model;
        private Driver _selectedDriver;

        public ManageDriversForm()
        {
            InitializeComponent();
        }

        private void ManageDrivers_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedDriver = null;

            dgvDrivers.DataSource = (from driver in _model.Drivers
                                     select driver).ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            if(_selectedDriver == null)
            {
                Driver driver = new Driver()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text
                };

                _model.Drivers.Add(driver);
            }
            else
            {
                _selectedDriver.FirstName = tbFirstName.Text;
                _selectedDriver.LastName = tbLastName.Text;
            }
            
            _model.SaveChanges();
            ClearInputs();
        }

        private void ClearInputs()
        {
            Helper.ClearInputs(groupBox1.Controls);
            _selectedDriver = null;
            dgvDrivers.DataSource = _model.Drivers.Select(driver => driver).ToList();
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
                return false;

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvDrivers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvDrivers.CurrentRow == null)
                return;

            var selectedDriver = (Driver)dgvDrivers.Rows[e.RowIndex].DataBoundItem;
            if (selectedDriver == null)
                return;

            _selectedDriver = selectedDriver;
            tbFirstName.Text = _selectedDriver.FirstName;
            tbLastName.Text = _selectedDriver.LastName;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDriver == null)
                return;

            DialogResult result = MessageBox.Show($"Are you sure to delete the driver called {_selectedDriver.FirstName}?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _model.Drivers.Remove(_selectedDriver);
                _model.SaveChanges();
                ClearInputs();
            }
        }
    }
}
