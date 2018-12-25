using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirmaKayit.Hangar
{
    class Mesajlar
    {
        public void YeniKayit(string mesaj)
        {
            MessageBox.Show(mesaj,"Yeni Kayıt Giriş",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili Olan Kayıt Güncellenecektir. \n Güncelleme İşlemini onaylıyor musunuz?","Güncelleme İşlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
        }
        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili Olan Kayıt Silinecektir.", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public void Guncelle(bool guncelleme)
        {
            MessageBox.Show("Kayıt Guncellenmiştir.","Kayıt Güncelleme",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message,"Hata Oluştu",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
