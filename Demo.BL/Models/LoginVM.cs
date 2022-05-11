﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Demo.BL.Models
{
    public class LoginVM
    {

        [Required(ErrorMessage = "Email Required")]
        [EmailAddress(ErrorMessage = "Invalid mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password Required")]
        [MinLength(6, ErrorMessage = "Min Len 6")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }


    }
}
