using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fardin.Core.DTO
{
    public class SubmitCommentViewModel
    {
        public string Text { get; set; }
        [Required(ErrorMessage = "Please enter your Name")]
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter your Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email")]
        public string Email { get; set; }
    }
}
