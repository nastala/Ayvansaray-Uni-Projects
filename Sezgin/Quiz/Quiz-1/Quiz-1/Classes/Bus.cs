using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1.Classes
{
    public class Bus
    {
        [Key]
        public int BusID { get; set; }
        public int SeatCount { get; set; }
        public string Name { get; set; }
        public string Plate { get; set; }
        public byte[] Image { get; set; }
        
        [Index(IsUnique = true)]
        public int? DriverID { get; set; }
    }
}
