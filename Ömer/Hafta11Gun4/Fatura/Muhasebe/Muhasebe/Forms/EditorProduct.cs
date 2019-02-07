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
    public partial class EditorProduct : Form
    {
        private EditorControl<Product> _editorControlProduct;

        public EditorProduct()
        {
            InitializeComponent();

            _editorControlProduct = new EditorControl<Product>();
            _editorControlProduct.UpsertClick += GetProduct;
            _editorControlProduct.SelectedItemChanged += Product_SelectedItemChanged;
            _editorControlProduct.AddTo(this);
            _editorControlProduct.Filter = true;

            cBUnits.LoadEntities<Unit>();
        }

        private void Product_SelectedItemChanged(Product obj)
        {
            tBProductName.Text = obj.Name;
            cBUnits.SetSelected(obj.Unit);
            tBUnitPrice.Text = obj.UnitPrice.ToString();
            tBProductCode.Text = obj.Code;
        }

        private Product GetProduct(DatabaseUpsertType dUT)
        {
            return new Product
            {
                Name = tBProductName.Text,
                Unit = cBUnits.GetSelected<Unit>(),
                Code = tBProductCode.Text,
                UnitPrice = double.Parse(tBUnitPrice.Text)
            };
        }

        private void Units_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var selectedUnitId = cBUnits.GetSelected<Unit>()?.Id;
            //if (selectedUnitId != null)
            //{
            //    _editorControlProduct.ApplyFilter(x => x.Unit.Id == selectedUnitId);
            //}
        }
    }
}
