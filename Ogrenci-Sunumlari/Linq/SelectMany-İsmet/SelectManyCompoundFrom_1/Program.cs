using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqVeriKaynagi;


namespace SelectManyCompoundFrom_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Ogrenciler =Class1.OgrencileriGetir();
            List<KulupKaydi> Kulupler = Class1.KulupleriGetir();
            var UyeOlunanKulupler = from Ogrenci in Ogrenciler
                                    from Kulup in Kulupler
                                    where Kulup.KayitNo == Ogrenci.Kulup
                                    select new { Ogrenci.Adi, KulupAdi = Kulup.Adi };
            Console.WriteLine("Öğrenciler ve kulüpleri :");
            foreach (var Satir in UyeOlunanKulupler)
            {
                Console.WriteLine("{0}, {1} kulübüne üye.", Satir.Adi, Satir.KulupAdi);
                
            }
            Console.ReadLine();

        }
        

        
    }
}
