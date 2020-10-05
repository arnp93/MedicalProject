using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.DTO
{
    public class DeletePostPageViewModel
    {
        public string postTitle { get; set; }
        public List<string> SubPostTitles { get; set; }
        public string postImage { get; set; }
        public int PostId { get; set; }
    }
}
