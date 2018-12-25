using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1_FirmaKayit.Hangar;

namespace Project_1_FirmaKayit.Bilgi
{
    public partial class FrmFirmaGiris : Form
    {
        private DBFirmaDataContext _db = new DBFirmaDataContext();
        private Formlar _f = new Formlar();
        private Mesajlar _m = new Mesajlar();
        private bool _edit = false;
        private Numaralar _n = new Numaralar();
        private FirmaTipi _firmaTipi = new FirmaTipi();

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

        private void FrmFirmaGiris_Load(object sender, EventArgs e)
        {
            Temizle();
            Combo();
        }

        private void Temizle()
        {
            foreach(Control control in splitContainer1.Panel1.Controls)
            {
                if (control is TextBox || control is ComboBox)
                    control.Text = "";
            }

            _edit = false;
            tbFirmaNo.Text = _n.FirmaNo();
        }

        private void Combo()
        {
            cbFirmaTipi.Items.Clear();
            cbFirmaTipi.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection aucFirmaTipleri = new AutoCompleteStringCollection();
            var firmaTipleri = _db.bgFirmaTipis.Select(item => item.Firma_Tipi).Distinct();

            foreach(string firmaTipi in firmaTipleri)
            {
                aucFirmaTipleri.Add(firmaTipi);
                cbFirmaTipi.Items.Add(firmaTipi);
            }
            cbFirmaTipi.AutoCompleteCustomSource = aucFirmaTipleri;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            VeriTabaninaKaydet();
            Temizle();
            Close();
            _f.FrmGir();
        }

        private void VeriTabaninaKaydet()
        {
            bgFirmaKayit bgFirmaKayit = new bgFirmaKayit
            {
                Firma_Adi = tbFirmaAdi.Text,
                Firma_Adres = tbAdres.Text,
                Firma_Departman = tbDepartman.Text,
                Firma_Email = tbEposta.Text,
                Firma_Fax = tbFaks.Text,
                Firma_No = Convert.ToInt32(tbFirmaNo.Text),
                Firma_Tel1 = tbTel1.Text,
                Firma_Tel2 = tbTel2.Text,
                Firma_Tipi = _firmaTipi.GetID(cbFirmaTipi.Text),
                Firma_Vergi_Dairesi = tbVergiDairesi.Text,
                Firma_Vergi_No = tbVergiNo.Text,
                Firma_Web = tbWebAdresi.Text,
                Firma_Yetkili = tbYetkili.Text,
                saveDate = DateTime.Now,
                saveUser = -1
            };

            _db.bgFirmaKayits.InsertOnSubmit(bgFirmaKayit);
            _db.SubmitChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnFormuKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class FirmaTipi
    {
        private Dictionary<int, string> tipler;
        private DBFirmaDataContext _db = new DBFirmaDataContext();

        public FirmaTipi()
        {
            tipler = new Dictionary<int, string>();
            fillValues();
            //values.Add(1, "MT");
            //values.Add(2, "Müşteri");
            //values.Add(3, "Şahıs");
            //values.Add(4, "Tedarikçi");
            //values.Add(5, "Alıcı");
        }

        private void fillValues()
        {
            var firmaDegerleri = _db.bgFirmaTipis.Select(item => item).Distinct();
            foreach(bgFirmaTipi tip in firmaDegerleri)
            {
                tipler.Add(tip.ID, tip.Firma_Tipi);
            }
        }

        //public void AddToDictionary(int key, string firmaTipi)
        //{
        //    values.Add(key, firmaTipi);
        //}

        public int GetID(string firmaTipi)
        {
            foreach(KeyValuePair<int, string> pair in tipler)
            {
                if (firmaTipi.Equals(pair.Value))
                    return pair.Key;
            }

            return 1;
        }
    }
}
