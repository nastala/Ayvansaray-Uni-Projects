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
    public partial class ManageCitiesForm : Form
    {
        private Model _model;
        private City _selectedCity;

        public ManageCitiesForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new Model();
            _selectedCity = null;
            dgvCities.DataSource = _model.Cities.ToList();
        }

        private void ClearInputs()
        {
            tbCityName.Text = "";
            _selectedCity = null;
            dgvCities.DataSource = _model.Cities.ToList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string cityName = tbCityName.Text;

            if (string.IsNullOrWhiteSpace(cityName))
                return;

            if (_selectedCity == null)
            {
                City city = new City()
                {
                    Name = cityName
                };

                _model.Cities.Add(city);
            }
            else
                _selectedCity.Name = cityName;

            _model.SaveChanges();
            ClearInputs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedCity == null)
                return;

            DialogResult result = MessageBox.Show($"Are you sure to delete city {_selectedCity.Name}?", "Attention", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                _model.Cities.Remove(_selectedCity);
                _model.SaveChanges();
                ClearInputs();
            }
        }

        private void dgvCities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvCities.CurrentRow == null)
                return;

            _selectedCity = (City)dgvCities.Rows[e.RowIndex].DataBoundItem;
            tbCityName.Text = _selectedCity.Name;
        }
    }
}
