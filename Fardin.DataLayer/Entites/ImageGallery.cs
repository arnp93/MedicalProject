using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class ImageGallery
    {
        public int ImageGalleryId { get; set; }
        public int postId { get; set; }
        public string ImageName { get; set; }
        public int subPostId { get; set; }

        #region Relations
        [ForeignKey("postId")]
        public virtual Post post { get; set; }
        //[ForeignKey("subPostId")]
        //public virtual SubPost SubPost{get; set;}
        #endregion
    }
}
