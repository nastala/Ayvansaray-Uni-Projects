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
    public partial class CategoryForm : Form
    {
        private NorthwindDataContext _dataContext;

        public CategoryForm()
        {
            InitializeComponent();

            _dataContext = new NorthwindDataContext();
            dgvMain.DataSource = _dataContext.Categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Category category = new Category()
            {
                CategoryName = tbCategoryName.Text,
                Description = tbDescription.Text
            };

            _dataContext.Categories.InsertOnSubmit(category);
            _dataContext.SubmitChanges();

            dgvMain.DataSource = _dataContext.Categories.GetNewBindingList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow == null)
                return;

            Category category = (Category)dgvMain.CurrentRow.DataBoundItem;

            _dataContext.Categories.DeleteOnSubmit(category);
            _dataContext.SubmitChanges();

            dgvMain.DataSource = _dataContext.Categories.GetNewBindingList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvMain.CurrentRow == null)
                return;

            Category category = (Category)dgvMain.CurrentRow.DataBoundItem;
            category.CategoryName = tbCategoryName.Text;
            category.Description = tbDescription.Text;

            _dataContext.SubmitChanges();

            dgvMain.DataSource = _dataContext.Categories.GetNewBindingList();
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvMain.Rows[e.RowIndex].Selected = true;

            tbCategoryName.Text = dgvMain.CurrentRow.Cells["CategoryName"].Value.ToString();
            tbDescription.Text = dgvMain.CurrentRow.Cells["Description"].Value.ToString();
        }

        private void CategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            dgvMain.DataSource = _dataContext.Categories.Where(category => category.CategoryName.Contains(tbSearch.Text));
        }
    }
}
