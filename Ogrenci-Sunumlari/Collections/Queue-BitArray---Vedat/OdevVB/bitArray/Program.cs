using System;
using System.Collections;

namespace bitArray
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] Sayilar = { 18, 26 };
            BitArray bitDizisi = new BitArray(Sayilar);

            // Çıktı: Bit Sayısı:16 
            Console.WriteLine("Bit Sayısı:" + bitDizisi.Count);
            Console.WriteLine();
            Console.WriteLine("Normal Sonuç:");
            EkranaYaz(bitDizisi);

            // bitDizisi koleksiyonu üzerinde mantıksal değil işlemini gerçekleştirildi.
            BitArray Not_bitDizisi = ((BitArray)bitDizisi.Clone()).Not();
            Console.WriteLine();
            Console.WriteLine("Not Sonuç:");
            EkranaYaz(Not_bitDizisi);

            // bitDizisi ve Not_bitDizisi koleksiyonları mantıksal VE(AND) işlemine tabi tutuldu.
            BitArray And_bitDizisi = bitDizisi.And(Not_bitDizisi);
            Console.WriteLine();
            Console.WriteLine("And Sonuç");
            EkranaYaz(And_bitDizisi);

            // bitDizisi ve Not_bitDizisi koleksiyonları mantıksal VEYA(OR) işlemine tabi tutuldu.
            BitArray Or_bitDizisi = bitDizisi.Or(Not_bitDizisi);
            Console.WriteLine("OR Sonuç:");
            EkranaYaz(Or_bitDizisi);

            // bitDizisi ve Not_bitDizisi koleksiyonları mantıksal ÖZEL VEYA(XOR) işlemine tabi tutuldu.
            BitArray Xor_bitDizisi = bitDizisi.Xor(Not_bitDizisi);
            Console.WriteLine();
            Console.WriteLine("XOR Sonuç:");
            EkranaYaz(Xor_bitDizisi);
            Console.ReadKey();
        }
        static void EkranaYaz(BitArray ba)
        {
            Console.WriteLine();
            for (int i = 0; i < ba.Count; i++)
            {
                Console.Write("{0,-6}", ba[i]);

                // Koleksiyon içerisindeki bitler 8 bitlik bloklara ayrıldı.
                if ((i + 1) % 8 == 0)
                    Console.WriteLine();
            }
        }
    }
}
