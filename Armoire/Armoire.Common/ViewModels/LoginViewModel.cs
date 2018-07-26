using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Armoire.Common.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Please enter your username")]
        public string UsernameRF { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string PasswordRF { get; set; }


    }
}
