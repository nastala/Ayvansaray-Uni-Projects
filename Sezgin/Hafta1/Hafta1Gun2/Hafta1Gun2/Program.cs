using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta1Gun2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hafta 1, Gun 2 <------> 22.11.2018

            //-------------------------------------------------------------------

            //int sayi;
            //Console.Write("Bir sayi giriniz: ");
            //sayi = Int32.Parse(Console.ReadLine());
            //if (sayi < 0)
            //    Console.WriteLine("Sayi negatif.");
            //else if(sayi == 0)
            //    Console.WriteLine("Sayi sifir.");
            //else
            //    Console.WriteLine("Sayi pozitif.");

            //-------------------------------------------------------------------

            //int fiyat;
            //Console.Write("Ürün fiyatini giriniz: ");
            //fiyat = Int32.Parse(Console.ReadLine());
            //if (fiyat < 100)
            //    Console.WriteLine("Fiyat: " + (fiyat + 5));
            //else
            //    Console.WriteLine("Fiyat: " + fiyat);

            //-------------------------------------------------------------------

            //int sayi;
            //Console.Write("Sayiyi giriniz: ");
            //sayi = Int32.Parse(Console.ReadLine());

            //if (sayi % 2 == 0)
            //    Console.WriteLine("Girdiğiniz sayi çifttir.");
            //else
            //    Console.WriteLine("Girdiğiniz sayi tektir.");

            //-------------------------------------------------------------------

            //int nResult = 0; 
            //int nSayi = 0;

            //Console.WriteLine("nResult: {0}, nSayi: {1}", nResult, nSayi);
            //Console.WriteLine("ilk işlem -> nResult: {0}, nSayi: {1}", ++nSayi * 4, nSayi);
            //Console.WriteLine("ilk işlemden sonraki değerler -> nResult: {0}, nSayi: {1}", nResult, nSayi);
            //Console.WriteLine("ikinci işlem -> nResult: {0}, nSayi: {1}", nSayi++ * 4, nSayi);
            //Console.WriteLine("ikinci işlemden sonraki değerler -> nResult: {0}, nSayi: {1}", nResult, nSayi);

            //-------------------------------------------------------------------

            //int pre = 0;
            //int post = 0;

            //while (pre < 10 || post < 10)
            //{
            //    Console.Write("Post-increment: " + post++ + " ");
            //    Console.WriteLine("Pre-increment: " + ++pre);
            //}

            //Console.WriteLine("pre's last value: " + pre + " post's last value: " + post);

            //-------------------------------------------------------------------

            //int A = 5;
            //int nResult = (A++) * 2;
            //Console.WriteLine("nResult: " + nResult);

            //Pre-increment = ++A
            //Post-increment = A++

            //-------------------------------------------------------------------

            //Console.Write("Kullanıcı adınızı girin: ");
            //string kullaniciAdi = Console.ReadLine();

            //Console.Write("Şifrenizi girin: ");
            //string sifre = Console.ReadLine();

            //if (kullaniciAdi.Equals("admin") && sifre.Equals("1234"))
            //    Console.WriteLine("Giriş işlemi başarılı.");
            //else
            //    Console.WriteLine("Kullanıcı adı veya şifre hatalı.");

            //-------------------------------------------------------------------

            //byte toplam;
            //int sayi = (int)Math.Pow(2, 9) + 2;
            //toplam = (byte)sayi;
            //Console.WriteLine("Toplam: " + toplam);

            //-------------------------------------------------------------------

            //Console.WriteLine("Size of char: " + sizeof(char) + " byte yer kaplar. Max: " + char.MaxValue + " Min: " + char.MinValue);
            //Console.WriteLine("Size of int: " + sizeof(int) + " byte yer kaplar. Max: " + int.MaxValue + " Min: " + int.MinValue);
            //Console.WriteLine("Size of bool: " + sizeof(bool) + " byte yer kaplar. Max: " + bool.TrueString + " Min: " + bool.FalseString);
            //Console.WriteLine("Size of float: " + sizeof(float) + " byte yer kaplar. Max: " + float.MaxValue + " Min: " + float.MinValue);
            //Console.WriteLine("Size of double: " + sizeof(double) + " byte yer kaplar. Max: " + double.MaxValue + " Min: " + double.MinValue);

            //-------------------------------------------------------------------

            //indentation -> tab olayı
            //WPF(Windows Presentation Foundation) / WCF(Windows Communication Foundation)
            //.Net -> Any programming language Compiler -> CIL(Common Intermediate Language) -> CLR(Common Language Runtime)
            //Java Compiler -> ByteCode -> JRE(Java Run-Time Environment)
            //CIL -> CLS(Common Language Specifications) -> CTS(Common Type System) ----- CIL bunların hepsine sahip
            //CIL -> JIT(Just in-time compiler(CIL çalıştırılacağı zaman makina koduna çevirir ve çalıştırır.)) -> Makine kodu
            //JIT'in üç tane yapısı var ---> CIL -> 1. JIT -> 2.EconoJIT -> 3. PreJIT
            //JIT -> Direk lazım olan yerleri derleyip hafızaya atıyor.(Orta)
            //EconoJIT -> Lazım olan yerleri her seferinde derliyor.(Yavaş)
            //PreJIT -> Her yazılan kodu direk derliyor, hafızaya atıyor.(Hızlı)

            //-------------------------------------------------------------------

            Console.ReadKey();
        }
    }
}
