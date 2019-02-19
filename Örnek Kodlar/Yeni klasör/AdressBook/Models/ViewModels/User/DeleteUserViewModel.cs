using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdressBook.Models.ViewModels.User
{
    public class DeleteUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string Password { get; set; }

        public int UserID { get; set; }
    }
}