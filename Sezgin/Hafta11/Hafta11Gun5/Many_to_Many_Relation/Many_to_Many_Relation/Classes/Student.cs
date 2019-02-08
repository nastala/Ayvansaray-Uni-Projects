using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_to_Many_Relation.Classes
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Teacher> Teachers { get; set; }

        public Student()
        {
            this.Teachers = new HashSet<Teacher>();
        }
    }
}
