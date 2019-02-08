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
    public partial class ManageStudentAndTeacherForm : Form
    {
        private UniversityModel _model;
        private Teacher _currentTeacher;

        public ManageStudentAndTeacherForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new UniversityModel();
            _currentTeacher = null;

            cbTeachers.DisplayMember = "FirstName";
            cbTeachers.ValueMember = "TeacherID";
            cbTeachers.DataSource = _model.Teachers.ToList();
        }

        private void FillDgvTeacherStudents()
        {
            if (_currentTeacher == null)
            {
                dgvTeacherStudents.DataSource = null;
                return;
            }

            dgvTeacherStudents.DataSource = _currentTeacher.Students.ToList();
        }

        private void cbTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillDgvTeacherStudents();
            FillLvStudents();

            if (cbTeachers.SelectedIndex == -1)
                return;

            _currentTeacher = (Teacher)cbTeachers.SelectedItem;
            
        }

        private void FillLvStudents()
        {
            lvStudents.Items.Clear();

            if (_currentTeacher == null)
                return;

            List<Student> students = _model.Students.ToList();
            List<Student> availableStudents = students.SkipWhile((s) => _currentTeacher.Students.Contains(s)).ToList();

            availableStudents.ForEach(s => lvStudents.Items.Add(s.FirstName));
        }
    }
}
