using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fardin.Core.DTO
{
    public class AdminPanelViewModel
    {
        [Required(ErrorMessage = "لطفا بخش مورد نظر را وارد کنید*")]
        public int SectionId { get; set; }
        //Post Properties
        public string PostText { get; set; }
        public string PostImg { get; set; }
        //SubPosts Properties
        public string PostTitle { get; set; }
        public string ImageName { get; set; }
        public string TextResumen { get; set; }
        //DetailsDescription Properties
        public string DetailsDescriptionText { get; set; }
        public string imageName { get; set; }
        public string videoName { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
