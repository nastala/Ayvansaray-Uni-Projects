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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentForm manageStudentForm = new ManageStudentForm();
            manageStudentForm.Show();
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTeacherForm manageTeacherForm = new ManageTeacherForm();
            manageTeacherForm.Show();
        }

        private void studentAndTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageStudentAndTeacherForm manageStudentAndTeacherForm = new ManageStudentAndTeacherForm();
            manageStudentAndTeacherForm.Show();
        }
    }
}
