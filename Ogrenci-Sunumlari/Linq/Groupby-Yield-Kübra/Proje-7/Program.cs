using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LinqOrnekleri_VeriKaynagi.Class1;

namespace Proje_7
{
    class Program
    {
        static IEnumerable<int> YieldReturnExample(IEnumerable<string> list)
        {
            foreach (var item in list)
            {
                yield return Convert.ToInt32(item);
                Console.WriteLine(item);
            }
            Console.WriteLine("Bitti");
        }
        static void Main(string[] args)
        {
            var res = YieldReturnExample(new[] { "1", "2", "3", "4" });
            foreach (var item in res)
            {
            }
            var studentList = OgrencileriGetir();
            var genderList = studentList.GroupBy(student => student.Cinsiyet);
            var clubList = studentList.GroupBy(student => student.Kulup);
            var genderAndClubList = studentList.GroupBy(
                student => new { student.Cinsiyet, student.Kulup },
                (keyFromAnonymous, studentListGroup) =>
                {
                    //return studentListGroup.Count();
                    return new
                    {
                        GroupKey = keyFromAnonymous,
                        Count = studentListGroup.Count(),
                        Students = studentListGroup
                                                .Select(
                                                singleS => singleS.Adi + " " + singleS.Soyadi)
                                                                            .OrderBy(x => x)
                    };
                }
            );
            foreach (var studentGroupedList in genderAndClubList)
            {
                Console.WriteLine(studentGroupedList.GroupKey.Cinsiyet + " Kulup :" + studentGroupedList.GroupKey.Kulup + " Count :" + studentGroupedList.Count);
                foreach (var student in studentGroupedList.Students)
                {
                    Console.WriteLine(student);
                }
            }
            //Console.WriteLine("__________________________");
            //foreach (var allGroupKey in genderAndClubList)
            //{
            //    Console.WriteLine(allGroupKey.Key.Cinsiyet+" - "+ allGroupKey.Key.Kulup +"Count :" + allGroupKey.Count());
            //    foreach (var currentStudent in allGroupKey)
            //    {
            //        Console.WriteLine(currentStudent.Adi + " " + currentStudent.Soyadi);
            //    }
            //    Console.WriteLine();
            //}
            Console.ReadKey();
        }
        //static dynamic Test(dynamic key, IEnumerable<LinqOrnekleri_VeriKaynagi.Kayit> studentListGroup)
        //{
        //    return new
        //    {
        //        GroupKey = key,
        //        Count = studentListGroup.Count(),
        //        Students = studentListGroup
        //                                        .Select(
        //                                        singleS => singleS.Adi + " " + singleS.Soyadi)
        //                                                                    .OrderBy(x => x)
        //    };
    }
}


