using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta2Gun2Part1
{
    class TestClass
    {
        public AnotherTestClass A;
        public TestStruct B;
        public TestClass(int val)
        {
            A = new AnotherTestClass
            {
                Number = val
            };
            B.Number = val;
        }
        public override string ToString()
        {
            return "Class Test Number :" + A.Number.ToString() + "\nStruct Test Number :" + B.Number.ToString();
        }
    }

    public class AnotherTestClass
    {
        public int Number;
    }
    public struct TestStruct
    {
        public int Number;
    }

    class Program
    {
        static void ShowArray(Array arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item?.ToString());
            }
        }
        static void Main(string[] args)
        {
            var days = new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", new TestClass(5) };
            var newDays = new object[8];
            Array.Copy(days, newDays, days.Length);
            days[0] = "Test";
            ((TestClass)days[7]).A.Number = 89;
            ((TestClass)days[7]).B.Number = 50;
            ShowArray(days);
            Console.WriteLine("_________________________________");
            ShowArray(newDays);
            Console.ReadKey();
        }
    }
}
