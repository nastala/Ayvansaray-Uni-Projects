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
    public partial class EditorUnit : Form
    {
        private EditorControl<Unit> _editorControlUnit;

        public EditorUnit()
        {
            InitializeComponent();

            _editorControlUnit = new EditorControl<Unit>();
            _editorControlUnit.UpsertClick += GetUnit;
            _editorControlUnit.SelectedItemChanged += Unit_SelectedItemChanged;
            _editorControlUnit.AddTo(this);
        }

        private void Unit_SelectedItemChanged(Unit obj)
        {
            tBUnitName.Text = obj.Name;
        }

        private Unit GetUnit(DatabaseUpsertType dUT)
        {
            return new Unit { Name = tBUnitName.Text };
        }
    }
}
