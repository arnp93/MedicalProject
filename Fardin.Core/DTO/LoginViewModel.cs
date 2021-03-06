﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fardin.Core.DTO
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Please enter your Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter your Password")]
        public string Password { get; set; }
    }
}
