using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_Template.App_Classes
{
    public class User
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid e-mail address")]
        public string Email { get; set; }

        [Required]
        public string SecretQuestion { get; set; }

        [Required]
        public string SecretAnswer { get; set; }
    }
}