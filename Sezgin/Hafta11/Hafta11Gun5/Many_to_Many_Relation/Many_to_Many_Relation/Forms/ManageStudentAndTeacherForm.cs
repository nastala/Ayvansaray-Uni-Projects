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
        private List<Student> _availableStudents;

        public ManageStudentAndTeacherForm()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            _model = new UniversityModel();
            _currentTeacher = null;
            _availableStudents = new List<Student>();

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
            if (cbTeachers.SelectedIndex == -1)
                return;

            _currentTeacher = (Teacher)cbTeachers.SelectedItem;

            FillDgvTeacherStudents();
            FillLvStudents();
        }

        private void FillLvStudents()
        {
            lvStudents.Items.Clear();

            if (_currentTeacher == null)
                return;

            List<Student> students = _model.Students.ToList();
            _availableStudents = students.SkipWhile((s) => _currentTeacher.Students.Contains(s)).ToList();

            _availableStudents.ForEach(s => lvStudents.Items.Add(s.FirstName));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lvStudents.SelectedItems)
            {
                _currentTeacher.Students.Add(_availableStudents[item.Index]);
            }

            _model.SaveChanges();
            FillDgvTeacherStudents();
            FillLvStudents();
        }
    }
}
