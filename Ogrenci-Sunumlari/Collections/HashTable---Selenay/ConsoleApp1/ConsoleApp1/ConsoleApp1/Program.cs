using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // Koleksiyonları kullanmak için projemize ekliyoruz

namespace HashTableSinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable dizi1 = new Hashtable();
            /* Add() metodu 2 parametre alır. key ve value */
            // add ile yada dizi gibi ekleme işlemi yapılabilir.
            dizi1.Add("Emrah ", "ASLAN");
            dizi1.Add("Yunus ", "BAYRAK");
            dizi1["Ali"] = 123;
            ICollection anahtar = dizi1.Keys;
            foreach (DictionaryEntry item in dizi1)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
            Console.ReadLine();

        }

    }

}