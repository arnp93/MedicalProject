using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.DataLayer.Entites
{
   public class Comment
    {
        public int CommentId { get; set; }
        public string Text { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool isPublic { get; set; }
        public bool isDelete { get; set; }
        public string LanguageTitle { get; set; }
        public DateTime Date { get; set; }
    }
}
