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
using Serialization_JSON_1.Classes;

namespace Serialization_JSON_1
{
    public partial class Form1 : Form
    {
        private List<Student> _students;

        public Form1()
        {
            InitializeComponent();
            _students = new List<Student>();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Name = tbStudentName.Text,
                Surname = tbStudentSurname.Text,
                BirthDate = dtpStudentBirthDate.Value
            };

            ClearTextBoxes();
            lbStudents.Items.Add(student);
            _students.Add(student);
        }

        private void ClearTextBoxes()
        {
            tbStudentName.Text = "";
            tbStudentSurname.Text = "";
        }

        private void btnToExternal_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "XML Dosya Kaydet";
            saveFileDialog.Filter = "(*.xml)|*.xml";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter writer = new StreamWriter(saveFileDialog.FileName);
                serializer.Serialize(writer, _students);
                writer.Close();
                MessageBox.Show("Dosya Kaydedildi");
            }
        }

        private void btnToInternal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            List<Student> newStudents = new List<Student>();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextReader reader = new StreamReader(openFileDialog.FileName);
                newStudents = (List<Student>)serializer.Deserialize(reader);
                fillList(newStudents);
                reader.Close();
            }
        }

        private void fillList(List<Student> students)
        {
            lbStudents.Items.Clear();
            foreach (var student in students)
            {
                lbStudents.Items.Add(student);
            }
        }
    }
}
