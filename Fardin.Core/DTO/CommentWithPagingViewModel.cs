using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.DTO
{
    public class CommentWithPagingViewModel
    {
        public List<CommentsViewModel> comments { get; set; }
        public int currentPage { get; set; }
        public int pageCount { get; set; }
    }
}
