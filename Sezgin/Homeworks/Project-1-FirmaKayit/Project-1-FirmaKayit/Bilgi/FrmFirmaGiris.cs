using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_FirmaKayit.Bilgi
{
    public partial class FrmFirmaGiris : Form
    {
        public FrmFirmaGiris()
        {
            InitializeComponent();
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            switch (splitContainer1.Panel2Collapsed)
            {
                case true:
                    splitContainer1.Panel2Collapsed = false;
                    btnCollapse.Text = "GIZLE";
                    break;
                case false:
                    splitContainer1.Panel2Collapsed = true;
                    btnCollapse.Text = "GOSTER";
                    break;
            }
        }
    }
}
