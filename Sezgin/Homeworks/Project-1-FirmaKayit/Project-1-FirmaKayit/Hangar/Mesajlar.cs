using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1_FirmaKayit.Hangar
{
    class Mesajlar
    {
        public static void YeniKayit(String mesaj)
        {
            MessageBox.Show(mesaj, "Yeni Kayıt Giriş", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili olan kayıt güncellenecektir. \n Onaylıyor musunuz?", "UYARI", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static DialogResult Sil()
        {
            return MessageBox.Show("Seçili olan kayıt silinecektir. \n Onaylıyor musunuz?", "UYARI",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void Guncelle(bool guncelle)
        {
            MessageBox.Show("Kayıt Güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Hata(Exception hata)
        {
            MessageBox.Show(hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
