using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdressBook.Models
{
    public class Adress
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public int UserID { get; set; }

        public virtual ICollection<Person> People { get; set; }
        public virtual User User { get; set; }
    }
}