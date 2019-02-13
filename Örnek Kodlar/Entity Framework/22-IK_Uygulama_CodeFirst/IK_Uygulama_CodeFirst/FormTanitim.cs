using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IK_Uygulama_CodeFirst
{
    public partial class FormTanitim : Form
    {
        public PersonelContext db;
        public FormTanitim()
        {
            InitializeComponent();
            db = new PersonelContext();

        }

        private void btnekle_Click(object sender, EventArgs e)
        {

        }
        //protected override void Dispose(bool disposing, bool tanitim)
        //{
        //    db.Dispose();
        //    base.Dispose(disposing);
        //}


    }
}
