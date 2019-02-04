﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingProject.Classes
{
    public class District
    {
        [Key]
        public int DistrictID { get; set; }
        public string Name { get; set; }
        public City City { get; set; }
    }
}
