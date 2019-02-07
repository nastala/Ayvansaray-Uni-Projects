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
    public partial class EditorInvoice : Form
    {
        private EditorControl<Invoice> _editorControlInvoice;

        public EditorInvoice()
        {
            InitializeComponent();

            _editorControlInvoice = new EditorControl<Invoice>(ColumnHide.ForeignKey | ColumnHide.Key, editorButtons: EditorButtons.None);
            _editorControlInvoice.AddTo(this);

            cBCities.LoadEntities<City>();
        }

        private void Customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customerId = cBCustomers.SelectedEntityId;
            _editorControlInvoice.ApplyFilter(x => x.CustomerId.Equals(customerId));
        }

        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCityId = cBCities.SelectedEntityId;
            cBDistricts.LoadEntities<District>(x => x.City.Id == selectedCityId);
        }

        private void Districts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDistrictId = cBDistricts.SelectedEntityId;
            cBCustomers.LoadEntities<Customer>(x => x.District.Id == selectedDistrictId);
        }

        private void InvoiceNo_TextChanged(object sender, EventArgs e)
        {
            int customerId = cBCustomers.SelectedEntityId;
            if (tBInvoiceNo.TextLength > 0)
            {
                _editorControlInvoice.ApplyFilter(x => x.CustomerId.Equals(customerId) && x.WaybillNumber.Contains(tBInvoiceNo.Text));
            }
            else
            {
                _editorControlInvoice.ApplyFilter(x => x.CustomerId.Equals(customerId));
            }
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
            _editorControlInvoice.RemoveFilter();
        }
    }
}
