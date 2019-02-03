using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Quiz_1.Classes.Helper;

namespace Quiz_1.Classes
{
    public class Passenger
    {
        [Key]
        public int PassengerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IdentityNumber { get; set; }
        public Gender Gender { get; set; }
    }
}
