using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hafta6Gun5_AnaProje;

namespace Hafta6Gun5_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            Hafta6Gun5_AnaProje.Classlar.Kisi kisi = new Hafta6Gun5_AnaProje.Classlar.Kisi();
            kisi.Ad = "Sezgin";
            kisi.Soyad = "Yağlı";
            string fullName = kisi.FullName();

            // protected
            // kisi.TCKimlik = 1;

            // protected 
            // kisi.KrediKartNo = 11111;

            // internal
            // kisi.Yas = 33;
            // private
            // fullName = kisi.adSoyad();

            Hafta6Gun5_AnaProje.Classlar.Ogrenci ogrenci = new Hafta6Gun5_AnaProje.Classlar.Ogrenci();

            // eklendi
            Classlar.Ogretmen ogretmen = new Classlar.Ogretmen();
            
            // protected internal
            // ogretmen.KrediKartNo = 123123;
        }
    }
}
