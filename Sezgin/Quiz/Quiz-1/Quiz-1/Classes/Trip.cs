using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1.Classes
{
    public class Trip
    {
        [Key]
        public int TripID { get; set; }
        public City DepartureCity { get; set; }
        public City ArrivalCity { get; set; }
        //public DateTime DepartureTime { get; set; }
        //public DateTime TripTime { get; set; }
        public bool IsLeft { get; set; }
        public Bus Bus { get; set; }
        public virtual ICollection<TripDetail> TripDetails { get; set; }

        public Trip()
        {
            this.TripDetails = new HashSet<TripDetail>();
        }
    }
}
