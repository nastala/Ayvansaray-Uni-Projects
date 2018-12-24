using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project_1_FirmaKayit.Bilgi;

namespace Project_1_FirmaKayit.Hangar
{
    class Formlar
    {
        #region Firma_Islemleri

        public void FrmGir()
        {
            FrmFirmaGiris frmFirmaGiris = new FrmFirmaGiris();
            frmFirmaGiris.MdiParent = Form.ActiveForm; //Application.OpenForms["AnaSayfa"] as AnaSayfa;
            frmFirmaGiris.WindowState = FormWindowState.Maximized;
            frmFirmaGiris.Show();
        }

        public int FrmListe(bool secim = false)
        {
            FrmFirmaListe frmFirmaListe = new FrmFirmaListe();
            if (secim)
            {
                frmFirmaListe.Secim = true;
                frmFirmaListe.ShowDialog();
            }
            else
            {
                frmFirmaListe.MdiParent = Form.ActiveForm;
                frmFirmaListe.Show();
            }

            return AnaSayfa.Aktarma;
        }

        #endregion
    }
}
