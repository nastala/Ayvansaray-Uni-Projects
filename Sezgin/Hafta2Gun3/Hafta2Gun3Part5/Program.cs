using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun3Part5
{
    class Program
    {
        //Hafta 2, Gün 3, Part 5 <-----> 28.11.2018

        public static string aciklama, islem;
        public static decimal sayi, sayi1, sayi2;
        public static decimal sonuc;

        static void Main(string[] args)
        {
            try
            {
                aciklama = "Lütfen girdiğiniz sayılarla ilgili işlemi seçiniz";
                islemSecimi(aciklama);
                sayiGirisi(islem);
                hesapMethodu(islem);
                yazdirma(sonuc);
            }
            catch (Exception)
            {
                Console.WriteLine("Sistemde beklenmedik bir hata oldu.");
            }
        }

        static void sayiGirisi(string islem)
        {
            Console.Clear();
            aciklama = "Birinci sayiyi giriniz: ";
            sayiKontrolu(aciklama);
            sayi1 = sayi;

            if(islem == "+" || islem == "-" || islem == "*" || islem == "/")
            {
                aciklama = "İkinci sayiyi giriniz: ";
                sayiKontrolu(aciklama);
                sayi2 = sayi;
                if(islem == "/" && sayi2 == 0)
                {
                    Console.WriteLine("Hata ikinci sayıyı sıfır giremezsiniz");
                    sayiGirisi(islem);
                }
            }
        }

        static decimal sayiKontrolu(string aciklama)
        {
            Console.WriteLine(aciklama);
            bool hata = false;
            try
            {
                sayi = Convert.ToDecimal(Console.ReadLine());
            }
            catch (Exception)
            {
                hata = true;
            }

            if (hata == false)
                return sayi;
            else
                return sayiKontrolu(aciklama = "Hatalı giriş yaptınız. Tekrar deneyiniz.");
        }

        static string islemSecimi(string aciklama)
        {
            Console.Clear();
            Console.Write(aciklama);
            bool hataYok = true;

            Console.WriteLine("İşlem Menüsü");
            Console.WriteLine("+: Toplama \n-: Çıkarma \n*: Çarpma \n/: Bölme \nk: Karekök");

            islem = Console.ReadLine();
            switch (islem)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
                case "k":
                    break;
                default:
                    hataYok = false;
                    break;
            }

            if (hataYok)
                return islem;
            else
                return islemSecimi(aciklama = "Hatalı giriş yaptınız. Lütfen tekrar deneyin.");
        }

        static decimal hesapMethodu(string islem)
        {
            if (islem == "+")
                sonuc = sayi1 + sayi2;
            else if (islem == "-")
                sonuc = sayi1 - sayi2;
            else if (islem == "*")
                sonuc = sayi1 * sayi2;
            else if (islem == "/")
                sonuc = sayi1 / sayi2;
            else if (islem == "k")
                sonuc = (decimal)Math.Sqrt((double)sayi1);

            return sonuc;
        }

        static void yazdirma(decimal sonuc)
        {
            if(islem == "+" || islem == "-" || islem == "*" || islem == "/")
            {
                Console.WriteLine("{0} {1} {2} işleminin sonucu: {3}", sayi1, islem, sayi2, sonuc);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0} {1} işleminin sonucu: {2}", sayi1, islem, sonuc);
                Console.ReadLine();
            }
        }
    }
}
