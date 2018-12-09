using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drag_Drop
{
    public partial class TableInfo : Form
    {
        public TableInfo(Table table)
        {
            InitializeComponent();
            lTableName.Text = table.Name;
            foreach (var tableAddition in table.Additions)
            {
                lBTableAdditions.Items.Add(tableAddition);
            }
        }
    }
}
