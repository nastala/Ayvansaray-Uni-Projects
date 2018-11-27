using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1Gun3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 1, Gun 3 <------> 23.11.2018

            //-------------------------------------------------------------------------------------------

            //Fal baktırmak isim, doğum tarih ilk -> 
            //1. aşama -> isim ve doğum tarihi(DateTime) girerken girilen ismin rakam içermediğinden ve tarihin geçerli bir formatta yazıldığından emin olun. (Kullanıcıyı tekrar giriş yaptır.) Ayrıca fal baktıracak kişi > 18, değilse programı sonlandır.
            //2. aşama -> çin burcu, tarihi çin burcunda kontrol et, burcunu ekrana yaz
            //1960 fare, 61 öküz ,62 kaplan, 63 tavşan, 64 ejderha, 65 yılan, 66 at, 67 keçi, 68 maymun, 69 horoz, 70 köpek, 71 domuz (mod 12)
            //3. aşama -> kişinin bir sonraki doğum gününün haftanın hangi günü olduğunu yaz.

            //-------------------------------------------------------------------------------------------

            //Kaç adet kitap sipariş edeceğini sor, sipariş miktarı < 20 ise birim fiyat * sipariş miktari, 20 <= sm <= 50 %5 , 50 < sm <= 100 %10, 100 < sm <= 200 %25
            //int birimFiyat = 100;
            //double toplamIndirim = 0;
            //double toplamTutar = 0;
            //int siparisMiktari;

            //Console.Write("Sipariş miktarını giriniz: ");
            //siparisMiktari = Int32.Parse(Console.ReadLine());

            //if (siparisMiktari <= 0)
            //{
            //    toplamTutar = 0;
            //}
            //else if (siparisMiktari < 20)
            //{
            //    toplamTutar = birimFiyat * siparisMiktari;
            //}
            //else if (siparisMiktari <= 50)
            //{
            //    toplamTutar = birimFiyat * siparisMiktari;
            //    toplamIndirim = toplamTutar * 0.05;
            //}
            //else if (siparisMiktari <= 100)
            //{
            //    toplamTutar = birimFiyat * siparisMiktari;
            //    toplamIndirim = toplamTutar * 0.1;
            //}
            //else if (siparisMiktari <= 200)
            //{
            //    toplamTutar = birimFiyat * siparisMiktari;
            //    toplamIndirim = toplamTutar * 0.25;
            //}
            //else
            //{
            //    Console.WriteLine("Sipariş miktarı 200'den büyük");
            //}

            //Console.Write("Siparişlerin indirimsiz ücreti: {0} \nUygulanan indirim: {1} \nÖdenmesi gereken toplam ücret: {2}", 
            //    toplamTutar, toplamIndirim, toplamTutar - toplamIndirim);

            //-------------------------------------------------------------------------------------------

            //Bir işyeri prim dağıtıyor. tabloya göre hesapla. maas + prim = toplam, 1 , 10 -> satış miktarı * 5,, 11, 25 -> * 11,, 26, 40 -> * 17,, 41, sonsuz -> * 30
            //int satisMiktari, tabanMaas, toplamMaas;

            //Console.Write("Taban maaşınızı giriniz: ");
            //tabanMaas = Int32.Parse(Console.ReadLine());

            //Console.Write("Satış miktarınızı giriniz: ");
            //satisMiktari = Int32.Parse(Console.ReadLine());

            //if (satisMiktari <= 0)
            //    toplamMaas = tabanMaas;
            //else if (satisMiktari <= 10)
            //    toplamMaas = satisMiktari * 5 + tabanMaas;
            //else if (satisMiktari <= 25)
            //    toplamMaas = satisMiktari * 11 + tabanMaas;
            //else if (satisMiktari <= 40)
            //    toplamMaas = satisMiktari * 17 + tabanMaas;
            //else
            //    toplamMaas = satisMiktari * 30 + tabanMaas;

            //Console.WriteLine("Bu ay alacağınız toplam maaş: {0:0.00}TL", toplamMaas);

            //-------------------------------------------------------------------------------------------

            //string sIsim;
            //int iTutar = 0;

            //Console.Write("Ürün adını giriniz: ");
            //sIsim = Console.ReadLine();

            //switch (sIsim)
            //{
            //    case "Bardak":
            //        iTutar = 4;
            //        break;
            //    case "Şemsiye":
            //        iTutar = 12;
            //        break;
            //    case "Kalem":
            //        iTutar = 2;
            //        break;
            //    default:
            //        iTutar = 0;
            //        break;
            //}

            //if (iTutar != 0)
            //    Console.WriteLine("{0}'nin fiyati: {1:0.00}TL", sIsim, iTutar);
            //else
            //    Console.WriteLine("{0} adında bir ürün bulunamadı.", sIsim);

            //-------------------------------------------------------------------------------------------

            //int iFiyat1, iFiyat2;
            //double dToplam;

            //Console.Write("1. Fiyati giriniz: ");
            //iFiyat1 = Int32.Parse(Console.ReadLine());

            //Console.Write("2. Fiyati giriniz: ");
            //iFiyat2 = Int32.Parse(Console.ReadLine());

            //dToplam = iFiyat1 + iFiyat2;
            //if(dToplam > 200)
            //    dToplam = iFiyat1 + iFiyat2 * 0.75;

            //Console.WriteLine("Toplam Fiyat: {0:0.00TL}", dToplam);

            //-------------------------------------------------------------------------------------------

            //int iSayi1, iSayi2;
            //char cIslem;
            //double dSonuc = 0;
            //bool bCheck = true;

            //Console.Write("İki sayi giriniz. \n1. Sayi: ");
            //iSayi1 = Int32.Parse(Console.ReadLine());

            //Console.Write("2. Sayi: ");
            //iSayi2 = Int32.Parse(Console.ReadLine());

            //Console.Write("Toplama için ---> t, Çıkarma için ---> ç, Çarpma için ---> x, Bölme için ---> b tuşuna basınız: ");
            //cIslem = Console.ReadKey().KeyChar;

            //if (cIslem.Equals('t'))
            //    dSonuc = iSayi1 + iSayi2;
            //else if (cIslem.Equals('ç'))
            //    dSonuc = iSayi1 - iSayi2;
            //else if (cIslem.Equals('x'))
            //    dSonuc = iSayi1 * iSayi2;
            //else if (cIslem.Equals('b'))
            //    dSonuc = (double)iSayi1 / (double)iSayi2;
            //else
            //{
            //    bCheck = false;
            //    Console.WriteLine("\nYanlış bir tuşa bastınız.");
            //}

            //if (bCheck)
            //{
            //    if(cIslem.Equals('b'))
            //        Console.WriteLine("\nSonuç: {0:0.00}", dSonuc);
            //    else
            //        Console.WriteLine("\nSonuç: " + dSonuc);
            //}

            //-------------------------------------------------------------------------------------------

            Console.ReadKey();
        }
    }
}
