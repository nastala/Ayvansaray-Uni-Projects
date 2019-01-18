using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    }
}
