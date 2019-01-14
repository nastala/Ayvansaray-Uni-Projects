using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doviz_Kurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            DataSet kurlar = new DataSet();
            kurlar.ReadXml("http://tcmb.gov.tr/kurlar/today.xml");
            dgvKurlar.DataSource = kurlar.Tables[1];
        }
    }
}
