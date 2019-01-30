using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWind.ORM.Façade;
using NorthWind.ORM.Entity;
using NorthWind.ORM;
using NortWind.ORM.Façade;

namespace NorthWind.UI
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            ListProducts();
            AdjustForeignKeyComboBoxes();
        }

        private void AdjustForeignKeyComboBoxes()
        {
            cProductCategory.DisplayMember = "CategoryName";
            cProductCategory.ValueMember = "CategoryID";
            cProductSupplier.DisplayMember = "CompanyName";
            cProductSupplier.ValueMember = "SupplierID";

            cProductSupplier.DataSource = Suppliers.Select;
            cProductCategory.DataSource = Categories.Select;

            cProductCategory.SelectedIndex = 0;
            cProductSupplier.SelectedIndex = 0;
        }

        private void ListProducts()
        {
            dGVMain.DataSource = Products.Select;
            dGVMain.Columns["ProductID"].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tProductName.Text) == false)
            {
                var product = new Product
                {
                    ProductName = tProductName.Text,
                    UnitPrice = nUDProductPrice.Value,
                    UnitsInStock = (short)nUDProductStock.Value,
                    SupplierID = (int)cProductSupplier.SelectedValue,
                    CategoryID = (int)cProductCategory.SelectedValue
                };
                product.Insert();
            }
        }
    }
}
