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
    public partial class EditorCity : Form
    {
        EditorControl<City> _editorControlCity;
        public EditorCity()
        {
            InitializeComponent();

            _editorControlCity = new EditorControl<City>();
            _editorControlCity.UpsertClick += CreateCity;
            _editorControlCity.SelectedItemChanged += City_SelectedItemChanged;
            _editorControlCity.AddTo(this);
        }

        private void City_SelectedItemChanged(City obj)
        {
            tBCityName.Text = obj.Name;
        }
        private City CreateCity(DatabaseUpsertType dUT) {
            return new City { Name = tBCityName.Text };
        }
    }
}
