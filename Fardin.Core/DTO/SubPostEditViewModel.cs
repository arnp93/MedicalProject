using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.DTO
{
    public class SubPostEditViewModel
    {
        public int SubPostId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public IFormFile Image { get; set; }
    }
}
