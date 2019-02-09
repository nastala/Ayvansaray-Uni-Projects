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
        public virtual City DepartureCity { get; set; }
        public virtual City ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime LastPurchasedTicketTime { get; set; }
        public bool IsLeft { get; set; }
        public virtual Bus Bus { get; set; }
        public virtual ICollection<TripDetail> TripDetails { get; set; }

        public Trip()
        {
            this.TripDetails = new HashSet<TripDetail>();
        }
    }
}
