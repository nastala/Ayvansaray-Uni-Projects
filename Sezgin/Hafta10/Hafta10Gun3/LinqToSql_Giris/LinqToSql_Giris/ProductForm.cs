using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSql_Giris
{
    public partial class ProductForm : Form
    {
        private NorthwindDataContext _dataContext = new NorthwindDataContext();
        private List<Product> _products;

        public ProductForm()
        {
            InitializeComponent();

            //dgvMain.DataSource = _dataContext.Products;

            cbCategory.DisplayMember = "CategoryName";
            cbCategory.ValueMember = "CategoryID";
            cbCategory.DataSource = _dataContext.Categories;

            cbSupplier.DisplayMember = "CompanyName";
            cbSupplier.ValueMember = "SupplierID";
            cbSupplier.DataSource = _dataContext.Suppliers;

            dgvMain.DataSource = _dataContext.Products;
            //dgvMain.DataSource = GetDataSource();
        }

        private IQueryable GetDataSource()
        {
            return from product in _dataContext.Products
                   join category in _dataContext.Categories on product.CategoryID equals category.CategoryID
                   select new
                   {
                       product.ProductID,
                       product.ProductName,
                       product.UnitPrice,
                       product.UnitsInStock,
                       product.CategoryID,
                       product.SupplierID,
                       product.QuantityPerUnit,
                       category.CategoryName
                   };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ProductName = tbProductName.Text;
            product.UnitPrice = nudUnitPrice.Value;
            product.UnitsInStock = Convert.ToInt16(nudUnitsInStock.Value);
            product.CategoryID = (int)cbCategory.SelectedValue;
            product.SupplierID = (int)cbSupplier.SelectedValue;

            _dataContext.Products.InsertOnSubmit(product);
            MessageBox.Show($"ProductID before SubmitChanges = {product.ProductID}");
            _dataContext.SubmitChanges();
            MessageBox.Show($"ProductID after SubmitChanges = {product.ProductID}");

            //dgvMain.DataSource = GetDataSource(); //63. ve 64. satırların işlevi aynı. İki şekilde de DataGridView'u güncelleyebiliriz. 
            //Bir diğer çözüm ise DataContext'i her seferinde tekrar initialize etmektir. _dataContext = new NorthwindDataContext();
            dgvMain.DataSource = _dataContext.Products.GetNewBindingList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow == null)
                return;

            int productID = (int)dgvMain.CurrentRow.Cells["ProductID"].Value;
            Product product = _dataContext.Products.SingleOrDefault(p => p.ProductID == productID);

            _dataContext.Products.DeleteOnSubmit(product);
            _dataContext.SubmitChanges();

            //dgvMain.DataSource = GetDataSource();
            dgvMain.DataSource = _dataContext.Products.GetNewBindingList();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvMain.CurrentRow;

            tbProductName.Text = row.Cells["ProductName"].Value.ToString();
            nudUnitPrice.Value = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
            nudUnitsInStock.Value = Convert.ToInt16(row.Cells["UnitsInStock"].Value);
            cbCategory.SelectedValue = (int)row.Cells["CategoryID"].Value;
            cbSupplier.SelectedValue = (int)row.Cells["SupplierID"].Value;

            dgvMain.Rows[e.RowIndex].Selected = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow == null)
                return;

            Product product = (Product)dgvMain.CurrentRow.DataBoundItem;
            product.ProductID = Convert.ToInt32(dgvMain.CurrentRow.Cells["ProductID"].Value);
            product.ProductName = tbProductName.Text;
            product.UnitPrice = nudUnitPrice.Value;
            product.UnitsInStock = Convert.ToInt16(nudUnitsInStock.Value);
            product.CategoryID = Convert.ToInt32(cbCategory.SelectedValue);
            product.SupplierID = Convert.ToInt32(cbSupplier.SelectedValue);

            _dataContext.SubmitChanges();
            //dgvMain.DataSource = GetDataSource();
            dgvMain.DataSource = _dataContext.Products.GetNewBindingList();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMain.DataSource = _dataContext.Products.Where(product => product.ProductName.Contains(tbSearch.Text));
        }

        private void btnOpenCategoryForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CategoryForm().Show();
        }
    }
}
