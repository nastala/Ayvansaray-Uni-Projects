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
    public partial class EditorInvoiceDetails : Form
    {
        private EditorControl<InvoiceDetail> _editorControlInvoiceDetail;
        private Dictionary<int, Invoice> _customerInvoice;
        private InvoiceDetail _selectedInvoiceDetail;

        public EditorInvoiceDetails()
        {
            _customerInvoice = new Dictionary<int, Invoice>();

            InitializeComponent();

            _editorControlInvoiceDetail = new EditorControl<InvoiceDetail>(ColumnHide.ForeignKey | ColumnHide.Key);
            _editorControlInvoiceDetail.UpsertClick += GetInvoiceDetail;
            _editorControlInvoiceDetail.SelectedItemChanged += InvoiceDetail_SelectedItemChanged;
            _editorControlInvoiceDetail.AddTo(this);

            cBCities.LoadEntities<City>();
            cBProducts.LoadEntities<Product>();
        }

        private InvoiceDetail GetInvoiceDetail(DatabaseUpsertType dUT)
        {
            var customer = cBCustomers.GetSelected<Customer>();
            Invoice invoice;
            if (_customerInvoice.ContainsKey(customer.Id) == false)
            {
                invoice = new Invoice();
                _customerInvoice.Add(customer.Id, invoice);
            }
            else
            {
                invoice = _customerInvoice[customer.Id];
            }
            invoice.Customer = customer;
            invoice.PaymentDate = dTPPaymentDate.Value;
            invoice.WaybillNumber = tBWaybill.Text;
            InvoiceDetail iD;
            switch (dUT)
            {
                case DatabaseUpsertType.Add:
                    iD = new InvoiceDetail
                    {
                        Invoice = invoice,
                        Product = cBProducts.GetSelected<Product>(),
                        Amount = (int)nUDProductCount.Value,
                        Tax = decimal.Parse(tBProductTax.Text.Substring(1)) * 0.1m,
                        Description = "None"
                    };
                    break;
                case DatabaseUpsertType.Update:
                    if (_selectedInvoiceDetail != null)
                    {
                        iD = _selectedInvoiceDetail;
                        iD.Invoice = invoice;
                        iD.Product = cBProducts.GetSelected<Product>();
                        iD.Amount = (int)nUDProductCount.Value;
                        iD.Tax = decimal.Parse(tBProductTax.Text.Substring(1)) * 0.1m;
                        iD.Description = "None";
                    }
                    else
                    {
                        iD = default(InvoiceDetail);
                    }
                    break;
                default:
                    iD = default(InvoiceDetail);
                    break;
            }
            return iD;
        }

        private void InvoiceDetail_SelectedItemChanged(InvoiceDetail obj)
        {
            _selectedInvoiceDetail = obj;
            cBCities.SetSelected(obj.Invoice.Customer.City);
            cBDistricts.SetSelected(obj.Invoice.Customer.District);
            cBCustomers.SetSelected(obj.Invoice.Customer);
            tBWaybill.Text = obj.Invoice.WaybillNumber;
            cBProducts.SetSelected(obj.Product);
            tBProductPrice.Text = obj.Product.UnitPrice.ToString();
            tBProductTax.Text = "%" + (obj.Tax * 10);
            tBProductUnit.Text = obj.Product.Unit.Name;
            nUDProductCount.Value = obj.Amount;
        }
        private void Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCityId = cBCities.SelectedEntityId;
            cBDistricts.LoadEntities<District>(x => x.City.Id == selectedCityId);
        }


        private void Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            var product = cBProducts.GetSelected<Product>();
            tBProductPrice.Text = product.UnitPrice.ToString();
            tBProductTax.Text = "%18";
            tBProductUnit.Text = product.Unit.Name;
            UpdatePriceSum();
        }

        private void Districts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDistrictId = cBDistricts.SelectedEntityId;
            cBCustomers.LoadEntities<Customer>(x => x.District.Id == selectedDistrictId);
        }

        private void ProductCount_ValueChanged(object sender, EventArgs e)
        {
            UpdatePriceSum();
        }

        private void UpdatePriceSum()
        {
            var selectedProduct = cBProducts.GetSelected<Product>();
            var price = nUDProductCount.Value * (decimal)selectedProduct.UnitPrice * 1.18m;
            lPriceSum.Text = price.ToString();
        }

        private void SaveInvoice_Click(object sender, EventArgs e)
        {
            _editorControlInvoiceDetail.CommitChanges();
        }

        private void EditorInvoice_FormClosing(object sender, FormClosingEventArgs e)
        {
            _editorControlInvoiceDetail.RevertChanges();
            _editorControlInvoiceDetail.Dispose();
        }
    }
}
