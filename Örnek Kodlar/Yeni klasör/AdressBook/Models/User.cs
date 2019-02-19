using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdressBook.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Password must contain at least 4 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress(ErrorMessage = "Invalid E-Mail Address")]
        public string Email { get; set; }

        public virtual ICollection<Adress> Adresses { get; set; }
    }
}