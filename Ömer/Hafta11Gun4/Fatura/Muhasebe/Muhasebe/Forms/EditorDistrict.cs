using Muhasebe.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Muhasebe.Forms
{
    public partial class EditorDistrict : Form
    {
        private EditorControl<District> _editorControlDistrict;

        public EditorDistrict()
        {
            InitializeComponent();


            _editorControlDistrict = new EditorControl<District>();
            _editorControlDistrict.UpsertClick += GetDistrict;
            _editorControlDistrict.SelectedItemChanged += District_SelectedItemChanged;
            _editorControlDistrict.AddTo(this);
            _editorControlDistrict.Filter = true;

            LoadCities();

        }

        private void LoadCities()
        {
            cBCities.LoadEntities<City>();
        }

        private void District_SelectedItemChanged(District obj)
        {
            tBDistrictName.Text = obj.Name;

            cBCities.SetSelected(obj.City);
        }

        private District GetDistrict(DatabaseUpsertType dUT)
        {
            return new District
            {
                City = cBCities.GetSelected<City>(),
                Name = tBDistrictName.Text
            };
        }

        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCityId = cBCities.GetSelected<City>()?.Id;
            if (selectedCityId != null)
            {
                _editorControlDistrict.ApplyFilter(x => x.City.Id.Equals(selectedCityId));
            }
        }
    }
}
