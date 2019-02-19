using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdressBook.Models
{
    public class Person
    {
        public int PersonID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        public string Gender { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Company { get; set; }

        [Required, StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must contain 10 numbers")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Phone characters must be a natural number")]
        public string Phone1 { get; set; }


        [StringLength(10, MinimumLength = 10, ErrorMessage = "Phone number must contain 10 numbers")]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Phone characters must be a natural number")]
        public string Phone2 { get; set; }
        public int AdressID { get; set; }

        [Display(Name = "Address")]
        public string PersonAddress { get; set; }

        public byte[] Photo { get; set; }

        public virtual Adress Adress { get; set; }
    }
}