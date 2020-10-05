using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.DTO
{
    public class CommentsViewModel
    {
        public string Text { get; set; }
        public string FullName { get; set; }
        public bool isPublic { get; set; }
        public int currentPage { get; set; }
        public int pageCount { get; set; }
        public DateTime Date { get; set; }
    }
}
