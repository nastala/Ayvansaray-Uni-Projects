using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGame
{
    public partial class FormMainPage : Form
    {
        private HashSet<string> _nameList;
        public FormMainPage()
        {
            InitializeComponent();
            _nameList = new HashSet<string>();
            foreach(var item in DatabaseConnection.GetValues<string>("SELECT ProductName FROM Products"))
            {
                _nameList.Add(item.Split(' ')[0]);
            }
        }

        private void NewGame_Click(object sender, EventArgs e)
        {
            lBFoundNames.Items.Clear();
            using (var fFI = new FormFirstInput())
            {
                var firstLetter = fFI.ShowDialogWindow();
                if (fFI.DialogResult == DialogResult.OK)
                {
                    FindWord(firstLetter);
                }
            }
        }

        private string FindWord(char firstLetter)
        {
            var found = _nameList.FirstOrDefault(name => char.ToUpperInvariant(name[0]) == char.ToUpperInvariant(firstLetter));
            if (found == null)
            {
                MessageBox.Show("No other name found");
            }
            else
            {
                var newFirstLetter = found[found.Length - 1];
                lBFoundNames.Items.Add(found);
                return FindWord(newFirstLetter);
            }
            return found;
        }
    }
}
