using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1.Classes
{
    public class Driver
    {
        [Key]
        public int DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? BusID { get; set; }
    }
}
