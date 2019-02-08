using Many_to_Many_Relation.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Many_to_Many_Relation.Forms
{
    public partial class ManageStudentForm : Form
    {
        private UniversityModel _model;
        private Student _selectedStudent;

        public ManageStudentForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new UniversityModel();
            _selectedStudent = null;

            FillDgvStudents();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            if (_selectedStudent == null)
            {
                Student student = new Student()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text
                };

                _model.Students.Add(student);
            }
            else
            {
                _selectedStudent.FirstName = tbFirstName.Text;
                _selectedStudent.LastName = tbLastName.Text;
            }

            _model.SaveChanges();
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selectedStudent = null;
            tbFirstName.Text = "";
            tbLastName.Text = "";

            FillDgvStudents();
        }

        private void FillDgvStudents()
        {
            dgvStudents.DataSource = _model.Students.ToList();
            dgvStudents.Columns["StudentID"].Visible = false;
            dgvStudents.Columns["Teachers"].Visible = false;
        }

        private bool CheckInputs()
        {
            if (string.IsNullOrWhiteSpace(tbFirstName.Text))
                return false;

            if (string.IsNullOrWhiteSpace(tbLastName.Text))
                return false;

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_selectedStudent == null)
                return;

            DialogResult result = MessageBox.Show($"Are you sure to delete {_selectedStudent.FirstName} {_selectedStudent.LastName}?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _model.Students.Remove(_selectedStudent);
                _model.SaveChanges();
                ClearInputs();
            }
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvStudents.CurrentRow == null)
                return;

            _selectedStudent = (Student)dgvStudents.CurrentRow.DataBoundItem;
            tbFirstName.Text = _selectedStudent.FirstName;
            tbLastName.Text = _selectedStudent.LastName;
        }
    }
}
