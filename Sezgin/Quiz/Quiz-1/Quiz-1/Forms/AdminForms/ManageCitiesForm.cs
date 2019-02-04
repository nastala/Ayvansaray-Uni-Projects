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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            if(_selectedCity == null)
            {
                City city = new City()
                {
                    Name = tbName.Text,
                    PlateNumber = Int32.Parse(tbPlateNumber.Text)
                };

                _model.Cities.Add(city);
            }
            else
            {
                _selectedCity.Name = tbName.Text;
                _selectedCity.PlateNumber = Int32.Parse(tbPlateNumber.Text);
            }

            _model.SaveChanges();
            ClearInputs();
        }

        private void ClearInputs()
        {
            Helper.ClearInputs(groupBox1.Controls);
            _selectedCity = null;
            dgvCities.DataSource = _model.Cities.ToList();
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(tbPlateNumber.Text))
                return false;

            try
            {
                Int32.Parse(tbPlateNumber.Text);
            }
            catch (FormatException)
            {
                return false;
            }

            return true;
        }
    }
}
