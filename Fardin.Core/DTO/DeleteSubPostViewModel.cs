using Fardin.DataLayer.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.DTO
{
    public class DeleteSubPostViewModel
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string detailDescriptions { get; set; }
    }
}
