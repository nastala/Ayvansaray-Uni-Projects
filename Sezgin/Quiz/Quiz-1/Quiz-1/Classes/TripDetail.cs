using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1.Classes
{
    public class TripDetail
    {
        [Key]
        public int TripDetailsID { get; set; }
        public Passenger Passenger { get; set; }
        public int SeatNumber { get; set; }
        public Trip Trip { get; set; }
    }
}
