using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Drag_Drop
{
    public partial class FMain : Form
    {
        private int _lastTableIndex;
        private Additions _additions;
        private Dictionary<string, Table> _tables;
        public FMain()
        {
            InitializeComponent();
            _tables = new Dictionary<string, Table>();
        }

        private void Additions_Click(object sender, EventArgs e)
        {
            if (_additions == null)
            {
                _additions = new Additions();
            }

            if (_additions.IsOn == false)
            {
                _additions.Show();
                _additions.IsOn = true;
            }
            else
            {
                _additions.Activate();
            }
        }

        private void Tables_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Link;
        }

        private void Tables_DragDrop(object sender, DragEventArgs e)
        {
            var point = lVTables.PointToClient(new Point(e.X, e.Y));
            var lvi = lVTables.GetItemAt(point.X, point.Y);
            if (lvi != null)
            {
                var selectedTable = _tables[lvi.Name];
                selectedTable.Additions.Add((Addition)e.Data.GetData(typeof(Addition)));
            }
        }

        private void AddTable_Click(object sender, EventArgs e)
        {
            var newTable = new Table
            {
                ImageIndex = 0, Name = "Table " + (++_lastTableIndex), Additions = new List<Addition>()
            };
            _tables[newTable.Name] = newTable;
            lVTables.Items.Add(newTable.Name, newTable.Name, newTable.ImageIndex);
        }

        private void Tables_DoubleClick(object sender, EventArgs e)
        {
            if (lVTables.SelectedIndices.Count > 0)
            {
                var selectedItem = lVTables.SelectedItems[0];
                var selectedTable = _tables[selectedItem.Text];
                using (var infoForm = new TableInfo(selectedTable))
                {
                    infoForm.ShowDialog();
                }
            }
        }
    }
}
