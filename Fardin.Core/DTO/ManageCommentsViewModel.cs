using Fardin.DataLayer.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.DTO
{
    public class ManageCommentsViewModel
    {
        public List<Comment> comments { get; set; }
        public int currentPage { get; set; }
        public int pageCount { get; set; }
    }
}
