using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var model = new Model1();

            var studentList = new List<Student>
            {
                new Student
                {
                    FirstName = "Sezgin",
                    LastName = "Yağlı"
                },
                new Student
                {
                    FirstName = "Kamil",
                    LastName = "Kara"
                },
                new Student
                {
                    FirstName = "İsmail",
                    LastName = "Ada"
                }
            };
            
            model.Teachers.Add(new Teacher
            {
                Name = "Tarık Keskin",
                Students = studentList
            });
            model.SaveChanges();

            foreach (var item in model.Teachers.FirstOrDefault().Students)
            {
                Console.WriteLine(item.FirstName + ' ' + item.LastName);
            }

            Console.ReadKey();
        }
    }
}
