using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization_JSON_1.Classes
{
    public class Student
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public Student()
        {
            this.ID = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
