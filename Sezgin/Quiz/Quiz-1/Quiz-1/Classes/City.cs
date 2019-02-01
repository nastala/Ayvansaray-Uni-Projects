using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1.Classes
{
    public class City
    {
        [Key]
        public int PlateNumber { get; set; }
        public string Name { get; set; }
    }
}
