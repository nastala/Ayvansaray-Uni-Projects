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
    public partial class ManageTeacherForm : Form
    {
        private UniversityModel _model;
        private Teacher _selectedTeacher;

        public ManageTeacherForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new UniversityModel();
            _selectedTeacher = null;

            FillDgvTeachers();
        }

        private void FillDgvTeachers()
        {
            dgvTeachers.DataSource = _model.Teachers.ToList();
            dgvTeachers.Columns["TeacherID"].Visible = false;
            dgvTeachers.Columns["Students"].Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckInputs())
                return;

            if (_selectedTeacher == null)
            {
                Teacher teacher = new Teacher()
                {
                    FirstName = tbFirstName.Text,
                    LastName = tbLastName.Text
                };

                _model.Teachers.Add(teacher);
            }
            else
            {
                _selectedTeacher.FirstName = tbFirstName.Text;
                _selectedTeacher.LastName = tbLastName.Text;
            }

            _model.SaveChanges();
            ClearInputs();
        }

        private void ClearInputs()
        {
            _selectedTeacher = null;
            tbFirstName.Text = "";
            tbLastName.Text = "";

            FillDgvTeachers();
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
            if (_selectedTeacher == null)
                return;

            DialogResult result = MessageBox.Show($"Are you sure to delete {_selectedTeacher.FirstName} {_selectedTeacher.LastName}?", "Attention", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _model.Teachers.Remove(_selectedTeacher);
                _model.SaveChanges();
                ClearInputs();
            }
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 || dgvTeachers.CurrentRow == null)
                return;

            _selectedTeacher = (Teacher)dgvTeachers.CurrentRow.DataBoundItem;
            tbFirstName.Text = _selectedTeacher.FirstName;
            tbLastName.Text = _selectedTeacher.LastName;
        }
    }
}
