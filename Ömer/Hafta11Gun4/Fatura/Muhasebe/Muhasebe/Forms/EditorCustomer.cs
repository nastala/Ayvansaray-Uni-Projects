using Muhasebe.Entities;
using System;
using System.Windows.Forms;

namespace Muhasebe.Forms
{
    public partial class EditorCustomer : Form
    {
        private EditorControl<Customer> _editorControlCustomer;

        public EditorCustomer()
        {
            InitializeComponent();

            _editorControlCustomer = new EditorControl<Customer>();
            _editorControlCustomer.UpsertClick += GetCustomer;
            _editorControlCustomer.SelectedItemChanged += Customer_SelectedItemChanged;
            _editorControlCustomer.AddTo(this);

            cBCities.LoadEntities<City>();
        }

        private void Customer_SelectedItemChanged(Customer obj)
        {
            tBCustomerTitle.Text = obj.Title;
            tBAddress.Text = obj.Address;
            cBCities.SetSelected(obj.City);
            cBDistricts.SetSelected(obj.District);
        }

        private Customer GetCustomer(DatabaseUpsertType dUT)
        {
            return new Customer
            {
                Title = tBCustomerTitle.Text,
                District = cBDistricts.GetSelected<District>(),
                City = cBCities.GetSelected<City>(),
                Address = tBAddress.Text
            };
        }

        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCityId = cBCities.SelectedEntityId;
            cBDistricts.LoadEntities<District>(x => x.City.Id == selectedCityId);
        }
    }
}
