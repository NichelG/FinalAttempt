using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Armoire.Common
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter your first name")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        //does not show up on the registration form
        //public string Phone { get; set; }
        //public string Address { get; set; }
        //public string City { get; set; }
        //public string State { get; set; }
        //public string Zip { get; set; }
        public byte[] Image { get; set; }

        //set something up to give admin access these variables
        public string AccountType { get; set; }
        public string AccountStatus { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
