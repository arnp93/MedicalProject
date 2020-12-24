using System;
using System.ComponentModel.DataAnnotations.Schema;

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
        #endregion
    }
}
