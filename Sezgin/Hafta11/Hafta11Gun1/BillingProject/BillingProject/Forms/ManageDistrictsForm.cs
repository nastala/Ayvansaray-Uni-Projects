using BillingProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillingProject.Forms
{
    public partial class ManageDistrictsForm : Form
    {
        private Model _model;
        private District _selectedDistrict;

        public ManageDistrictsForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedDistrict = null;
            dgvDistricts.DataSource = _model.Districts.ToList();

            cbCities.DisplayMember = "Name";
            cbCities.ValueMember = "CityID";
            cbCities.DataSource = _model.Cities.ToList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            dgvDistricts.DataSource = _model.Districts.ToList();
            _selectedDistrict = null;
            tbDistrictName.Text = "";
            cbCities.SelectedItem = null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string districtName = tbDistrictName.Text;
            City city = (City)cbCities.SelectedItem;

            if (string.IsNullOrWhiteSpace(districtName))
                return;

            if (city == null)
                return;

            if(_selectedDistrict == null)
            {
                District district = new District()
                {
                    Name = districtName,
                    City = city
                };

                _model.Districts.Add(district);
            }
            else
            {
                _selectedDistrict.Name = districtName;
                _selectedDistrict.City = city;
            }

            _model.SaveChanges();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedDistrict == null)
                return;

            DialogResult result = MessageBox.Show($"Are you sure to delete district {_selectedDistrict.Name}?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _model.Districts.Remove(_selectedDistrict);
                _model.SaveChanges();
                ClearInputs();
            }
        }

        private void dgvDistricts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvDistricts.CurrentRow == null)
                return;

            _selectedDistrict = (District)dgvDistricts.CurrentRow.DataBoundItem;
            tbDistrictName.Text = _selectedDistrict.Name;
            cbCities.SelectedItem = _selectedDistrict.City;
        }
    }
}
