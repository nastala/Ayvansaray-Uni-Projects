using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthWind.ORM.Entity;
using NorthWind.ORM.Façade;
using NorthWind.ORM;

namespace NorthWind.UI
{
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            ListCategories();
        }

        private void ListCategories()
        {
            dGVMain.DataSource = Categories.Select;
            dGVMain.Columns["CategoryID"].Visible = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tCategoryName.Text) == false && string.IsNullOrWhiteSpace(tDescription.Text) == false)
            {
                var cat = new Category
                {
                    CategoryName = tCategoryName.Text,
                    Description = tDescription.Text
                };
                cat.Insert();
            }
        }
    }
}
