using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fardin.DataLayer.Entites
{
   public class ContactUs
    {
        public int ContactUsId { get; set; }
        [Required(ErrorMessage = "لطفا نام خود را وارد کنید - Please enter your Name")]
        [MaxLength(30,ErrorMessage = "حداکثر حروف مجاز 30 کاراکتر می باشد - The maximum number of characters allowed is 30 characters")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "لطفا ایمیل خود را وارد کنید - Please enter your Email Address")]
        [MaxLength(30, ErrorMessage = "حداکثر حروف مجاز 30 کاراکتر می باشد - The maximum number of characters allowed is 30 characters")]
        public string Email { get; set; }
        [MaxLength(30, ErrorMessage = "حداکثر شماره مجاز 30 عدد می باشد - The maximum number allowed is 30")]
        [Phone(ErrorMessage ="شماره تلفن وارد شده معتبر نمیباشد - Your phone number is'nt Valid")]
        public string PhoneNumber { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
    }
}
