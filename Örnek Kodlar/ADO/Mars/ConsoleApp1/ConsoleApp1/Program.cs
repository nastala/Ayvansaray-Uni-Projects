using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;MultipleActiveResultSets=True");

                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Orders", con);
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM [Order Details] WHERE OrderID=@orderID", con);
                cmd2.Parameters.Add("@orderID", SqlDbType.Int);

                SqlDataReader dr1;
                SqlDataReader dr2;

                con.Open();
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Console.WriteLine(dr1["OrderID"]);
                    Console.WriteLine(" Sipariş Detayları....");
                    cmd2.Parameters["@OrderID"].Value = dr1["OrderID"];
                    dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        Console.WriteLine(dr2["ProductID"] + " " + dr2["UnitPrice"] + " " + dr2["Quantity"]);
                    }
                    dr2.Close();
                    Console.WriteLine("------------");
                }

                con.Close();
                Console.ReadLine();
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message);
                Console.ReadLine();
            }
        }
    }
}
