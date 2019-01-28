using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqVeriKaynagi;

namespace SelectManyCompoundFrom_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kayit> Ogrenciler = Class1.OgrencileriGetir();
            List<KulupKaydi> Kulupler = Class1.KulupleriGetir();
            // Where ile
            //var UyeOlunanKulupler = from Ogrenci in Ogrenciler
            //                        from Kulup in Kulupler
            //                        where Ogrenci.Ortalama >= 85 && Kulup.KayitNo == Ogrenci.Kulup
            //                        select new { Ogrenci.Adi, KulupAdi = Kulup.Adi };
            //Join ile
            var UyeOlunanKulupler = from Ogrenci in Ogrenciler
                                    join
                                    Kulup in Kulupler
                                    on Ogrenci.Kulup equals Kulup.KayitNo
                                    into KulupveOgrenciler
                                    where Ogrenci.Ortalama >= 85
                                    select new {KulupAdi = KulupveOgrenciler.Select(x=>x.Adi),
                                    Ogrenci.Soyadi};


            Console.WriteLine("Ortalaması pekiyi olan öğrenciler ve kulüpleri :");
            foreach (var Satir in UyeOlunanKulupler)
            {
                Console.WriteLine("{0}, {1} kulübüne üye.", Satir.Soyadi, Satir.KulupAdi);
            }
            Console.ReadLine();
        }
    }
}
