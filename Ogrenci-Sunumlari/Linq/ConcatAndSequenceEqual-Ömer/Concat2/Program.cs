using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FakeData.Fakes;

namespace Concat2
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = GetStudents();

            var firstGradeMale =
                       from student in students
                       where student.Grade == 1 && student.Sex == "Male"
                       select student.Name;

            var secondGradeMale =
                      from student in students
                      where student.Grade == 2 && student.Sex == "Male"
                      select student.Name;

            var firstAndSecondGradeMale =
                      firstGradeMale.Concat(secondGradeMale);

            Console.WriteLine("Students in first and second grade:");

            foreach (var studentName in firstAndSecondGradeMale)
            {
                Console.WriteLine(studentName);
            }
            Console.ReadLine();
        }
    }
}
