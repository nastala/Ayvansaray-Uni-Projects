using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hafta4Gun2Part2
{
    class Program
    {
        //Hafta 4, Gün 2, Part 2, Directory Info <-----> 11.12.2018

        static void Main(string[] args)
        {
            // Kullanılacak dizini tanımlama
            DirectoryInfo NewDir = new DirectoryInfo(@"C:\Test\TestDizini");
            try
            {
                // Dizinin var olup olmadığının kontrolü
                if (NewDir.Exists)
                {
                    Console.WriteLine("Dizin mevcut.");
                    // Dizin silme işlemi
                    NewDir.Delete(true);
                    Console.WriteLine("Dizin Silindi.");
                }

                // Yeni dizin oluşturma
                NewDir.Create();
                NewDir.Refresh();
                Console.WriteLine("Klasör oluşturuldu.");
                Console.WriteLine("Oluşturulma Tarihi: " + NewDir.CreationTime);
                Console.WriteLine("Bulunduğu Dizinin Adı: " + NewDir.Parent);
                Console.WriteLine("Dizinin Adı: " + NewDir.Name);
                Console.WriteLine("Dizinin Tam Adı: " + NewDir.FullName);
                Console.WriteLine("Son Erişim Tarihi: " + NewDir.LastAccessTime);
                Console.WriteLine("Son Değiştirilme Tarihi: " + NewDir.LastWriteTime);
                Console.ReadLine();

                // Diziniçerisinde ait dizin oluşturma
                DirectoryInfo SubDir = NewDir.CreateSubdirectory("AltDizin");
                // Alt dizin içerisinde ait dizini oluşturma
                SubDir.CreateSubdirectory("AltDizin2");
                // GetFiles ile dizindeki dosyaların seçimi
                Console.WriteLine("{0} dizinindeki dosya sayısı: {1}", NewDir.Name, NewDir.GetFiles().Length);
                // GetDirectory ile dizindeki klasörlerin seçimi
                Console.WriteLine("{0} dizinindeki klasör sayısı: {1}", NewDir.FullName, NewDir.GetDirectories().Length);

                Console.ReadLine();
            }
            catch (Exception exc)
            {
                Console.WriteLine("Hata oluştu. Hata mesajı: " + exc.Message);
            }

            Console.ReadLine();
        }
    }
}
