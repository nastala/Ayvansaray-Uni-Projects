using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 2, Gün 1 <-----> 26.11.2018

            //-------------------------------------------------------------------------------------------

            //checked -> explicit conversionlarda değer tam olarak sığmıyorsa(veri kaybı varsa) hata fırlatıyor. Unchecked -> kontrol etmiyor.
            //f10 -> methodu skipler, shift + f11 -> methodu direk skipler.
            //Admiral Grace Hopper wiki'den oku.
            //Context-sensitive: seçilem itema göre farklı farklı seçeneklerin çıkması
            //implicit conversion -> Kapalı dönüşüm -> Bir veri tipi kendisinden büyük bir veri tipine atanıyorsa implicit -> int a = byte b;
            //explicit conversion -> Açık dönüşüm -> Bir veri tipi kendisinden küçük bir veri tipine atanıyorsa explicit -> byte b = Convert(int a);

            //-------------------------------------------------------------------------------------------

            //1 -> 1-30'e kadar yazdır, 5 e bölünüyorsa BOOM
            //Thread.Sleep(500);
            //2 -> Boom sayılacak sayıyı giriniz, ona göre BOOM yaz
            //3 -> Boom yine kullanıcı tarafından girilecek, bilgisayar ile karşılıklı oynanacak, kullanıcı hiç yanılmazsa berabere, 

            //int iBoom = 5;

            //for(int i = 1; i <= 30; i++)
            //{
            //    if(i % iBoom == 0)
            //        Console.WriteLine("BOOM");
            //    else
            //        Console.WriteLine(i);

            //    Thread.Sleep(50);
            //}

            //Console.Write("BOOM sayısını giriniz: ");
            //try
            //{
            //    iBoom = Int32.Parse(Console.ReadLine());

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Hatalı bir değer girildi.");
            //    Environment.Exit(0);
            //}

            //for (int i = 1; i <= 30; i++)
            //{
            //    if (i % iBoom == 0)
            //        Console.WriteLine("BOOM");
            //    else
            //        Console.WriteLine(i);

            //    Thread.Sleep(50);
            //}

            //Console.Write("BOOM sayısını giriniz: ");
            //try
            //{
            //    iBoom = Int32.Parse(Console.ReadLine());

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Hatalı bir değer girildi.");
            //    Environment.Exit(0);
            //}

            //string sCevap = "";
            //string girilenSayi = "";

            //for (int i = 1; i <= 30; i++)
            //{
            //    if (i % iBoom == 0)
            //        sCevap = "BOOM";
            //    else
            //        sCevap = i.ToString();

            //    if (i % 2 == 0)
            //    {
            //        Console.Write("Siz: ");
            //        girilenSayi = Console.ReadLine();

            //        if (!(sCevap.Equals(girilenSayi.ToString())))
            //        {
            //            Console.WriteLine("Oyunu kaybettiniz.");
            //            Console.ReadKey();
            //            return;
            //        }
            //    }
            //    else
            //        Console.WriteLine("Bilgisayar: " + sCevap);

            //    Thread.Sleep(500);
            //}

            //Console.WriteLine("Oyun berabere");

            //-------------------------------------------------------------------------------------------

            //try
            //{
            //    int a = Int32.Parse(Console.ReadLine());
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Hata!");
            //    return;
            //}
            //finally
            //{
            //    Console.WriteLine("Hello from finally");
            //}

            //Console.WriteLine("I'm free.");

            //-------------------------------------------------------------------------------------------

            //int iAy;
            //string sAy;

            //Console.Write("Kaçıncı ayda olduğunuzu giriniz: ");
            //iAy = Int32.Parse(Console.ReadLine());

            //switch (iAy)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        sAy = "Kış";
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        sAy = "İlkbahar";
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        sAy = "Yaz";
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        sAy = "Sonbahar";
            //        break;
            //    default:
            //        sAy = "";
            //        break;
            //}

            //Console.WriteLine("Şu anki mevsim: " + sAy);

            //-------------------------------------------------------------------------------------------

            //int iSayi = 300;
            //try
            //{
            //    checked
            //    {
            //        unchecked
            //        {
            //            byte sayiByte1 = (byte)iSayi;
            //            Console.WriteLine(sayiByte1.ToString());
            //        }
            //
            //        byte sayiByte2 = (byte)iSayi;
            //        Console.WriteLine(sayiByte2.ToString());
            //    }
            //}
            //catch (Exception exc)
            //{
            //    Console.WriteLine(exc.Message);
            //}

            //-------------------------------------------------------------------------------------------

            //try
            //{
            //    int a = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine(3 / a);
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("0 a bölünemez hatası");
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("Hata var!");
            //}

            Console.ReadKey();

            //-------------------------------------------------------------------------------------------
        }
    }
}
