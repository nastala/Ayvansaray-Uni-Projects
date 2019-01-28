using static LinqOrnekleri_VeriKaynagi.Class1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karşılaştırıcı Kullanarak GroupBy Örneği
            var ogrenciler = OgrencileriGetir();

            var cinsiyeteGoreBasariListesi =
                ogrenciler.GroupBy(ogrenci => new { ogrenci.Basarili,ogrenci.Cinsiyet }
                , (groupKey, groupList) => 
                {
                    return new { GrupAdi = groupKey, Ortalama = groupList.Average(x=> x.Ortalama), Insanlar = groupList };
                });

            
            Console.WriteLine("Cinsiyete göre başarı durumları listesi...");

            foreach (var OgrenciGrubu in cinsiyeteGoreBasariListesi)
            {

                Console.WriteLine("\n{0} {1} :",
                                  OgrenciGrubu.GrupAdi.Basarili ? "Başarılı" : "Başarısız",
                                  OgrenciGrubu.GrupAdi.Cinsiyet == LinqOrnekleri_VeriKaynagi.Cinsiyet.Erkek ? "erkekler" : "bayanlar");
                foreach (var Ogrenci in OgrenciGrubu.Insanlar)
                {
                    Console.WriteLine("{0} {1}. Ortalaması {2:0.00}",
                                      Ogrenci.Adi, Ogrenci.Soyadi, Ogrenci.Ortalama);
                }
            }
            Console.ReadLine();

        }
    }

    //Örnekte kullanılan karşılaştırıcı sınıf şöyledir :


    //public class CinsiyeteGoreBasariKarsilastirici : IEqualityComparer
    //{

    //    public bool Equals(Kayit x, Kayit y)
    //    {

    //        if (x.Cinsiyet != y.Cinsiyet && x.Basarili != y.Basarili) return false;

    //        return true;

    //    }

    //    public int GetHashCode(Kayit Ogrenci)
    //    {

    //        return Ogrenci.Basarili.GetHashCode() + Ogrenci.Cinsiyet.GetHashCode();

    //    }

    //}

}
