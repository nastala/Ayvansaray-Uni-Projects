using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

namespace KelimeOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            // Adapter Fill method ile bir DataTable doldurulur.
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand("SELECT ProductName FROM Products", conn);
            DataTable myDT = new DataTable();

            while (true)
            {
                dataAdapter.Fill(myDT);

                // DataTable üzerinde foreach loop yaparak her satırin ilk kelimesinden sonrası temizlenir.
                foreach (DataRow r in myDT.Rows)
                {
                    string s = r["ProductName"].ToString();
                    //s = s.ToUpper();
                    if (s.Contains(' '))
                        s = s.Substring(0, s.IndexOf(' '));
                    r["ProductName"] = s;
                }

                // Hangi harfle başlayalım diye sorup ReadKey ile bir harf alınır. 
                Console.Write("Hangi harf ile baslayalim? ");
                char c = Console.ReadKey().KeyChar;
                Console.WriteLine();

                int i = 0;
                while (myDT.Rows.Count > 0)
                {
                    DataRow[] rows = myDT.Select(string.Format("ProductName like '{0}%' ", c));
                    if (rows.Length == 0)
                    {
                        Console.WriteLine("{0} ile başlayan kelime kalmadı.", c);
                        break;
                    }
                    ++i;
                    string s = rows[0]["ProductName"].ToString();
                    Console.WriteLine("   "+s);
                    // yeni kelimenin son harfini al
                    c = s[s.Length - 1];
                    myDT.Rows.Remove(rows[0]);
                }
                if (i > 0)
                    Console.WriteLine("{0} kelime bulundu", i);
            }
        }
    }
}
