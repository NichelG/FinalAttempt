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
        public string FirstnameRF { get; set; }

        [Required(ErrorMessage = "Please enter your last name")]
        public string LastnameRF { get; set; }

        [Required(ErrorMessage = "Please enter your username")]
        public string UsernameRF { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string PasswordRF { get; set; }

        [Required(ErrorMessage = "Please enter your email")]
        public string EmailRF { get; set; }

        //DELETE FROM TABLE
        //public string PhoneRF { get; set; }
        //public string AddressRF { get; set; }
        //public string CityRF { get; set; }
        //public string StateRF { get; set; }
        //public string ZipRF { get; set; }
        public byte[] ImageRF { get; set; }

        //set something up to give admin access these variables
        public string AccountTypeRF { get; set; }
        public string accountStatusRF { get; set; }
        public DateTime DateCreatedRF { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}
