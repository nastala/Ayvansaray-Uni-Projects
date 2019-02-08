using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Many_to_Many_Relation.Classes
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual ICollection<Student> Students { get; set; }

        public Teacher()
        {
            this.Students = new HashSet<Student>();
        }
    }
}
