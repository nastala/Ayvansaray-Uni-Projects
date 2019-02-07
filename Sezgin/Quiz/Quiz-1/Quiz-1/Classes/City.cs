using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_1.Classes
{
    public class City
    {
        [Key]
        public int CityID { get; set; }

        [Index(IsUnique = true)]
        public int PlateNumber { get; set; }
        public string Name { get; set; }
    }
}
