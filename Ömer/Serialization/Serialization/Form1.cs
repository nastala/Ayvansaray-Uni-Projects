using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Serialization
{
    public partial class Form1 : Form
    {
        XmlSerializer _personListSerializer = new XmlSerializer(typeof(List<Person>));
        List<Person> _personList = new List<Person>();
        SaveFileDialog _saveDialog = new SaveFileDialog();
        OpenFileDialog _importDialog = new OpenFileDialog();

        private bool IsFormValid
        {
            get
            {
                if (string.IsNullOrEmpty(tBName.Text) == true || tBName.TextLength < 2)
                {
                    return false;
                }
                if (string.IsNullOrEmpty(tBSurname.Text) == true || tBSurname.TextLength < 2)
                {
                    return false;
                }
                return true;
            }
        }
        public Form1()
        {
            InitializeComponent();
            _saveDialog.Filter = "XML|*.xml";
            _importDialog.Filter = "XML|*.xml";

            _saveDialog.FileName = "People";

            _saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (IsFormValid == true)
            {
                var person = new Person
                {
                    BirthDate = dTPBirthday.Value,
                    Name = tBName.Text,
                    Surname = tBSurname.Text
                };
                lbObjects.Items.Add(person);
                _personList.Add(person);
            }
        }

        private void Export_Click(object sender, EventArgs e)
        {
            if (_saveDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sW = new StreamWriter(_saveDialog.FileName))
                {
                    _personListSerializer.Serialize(sW, _personList);
                }
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            if (_importDialog.ShowDialog() == DialogResult.OK)
            {
                using (var sR = new StreamReader(_importDialog.FileName))
                {
                    var newPeople = (List<Person>)_personListSerializer.Deserialize(sR);
                    _personList.AddRange(newPeople);
                    lbObjects.Items.AddRange(newPeople.ToArray());
                }
            }
        }
    }
}
