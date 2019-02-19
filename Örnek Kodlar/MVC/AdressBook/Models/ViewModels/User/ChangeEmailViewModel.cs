using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AdressBook.Models.ViewModels.User
{
    public class ChangeEmailViewModel
    {
        public int UserID { get; set; }

        [Display(Name = "Current E-Mail")]
        public string OldEmail { get; set; }

        [Required]
        [Display(Name = "New E-Mail")]
        [EmailAddress(ErrorMessage = "Invalid E-Mail Address")]
        public string NewEMail { get; set; }
    }
}