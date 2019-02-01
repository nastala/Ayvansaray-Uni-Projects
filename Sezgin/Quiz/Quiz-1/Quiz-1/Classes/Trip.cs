using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1.Classes
{
    public class Trip
    {
        [Key]
        public int TripID { get; set; }
        public int DepartureCityID { get; set; }
        public int ArrivalCityID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime TripTime { get; set; }
        public int BusID { get; set; }
    }
}
