using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class Post
    {
        public Post()
        {

        }
        #region Properties
        public int PostId { get; set; }
        public int SectionId { get; set; }
        public string PostText { get; set; }
        public string Title { get; set; }
        public string PostImg { get; set; }
        public int AdminPanelId { get; set; }
        public string LanguageTitle { get; set; }
        public string Hashtags { get; set; }
        #endregion

        #region Relations
        public virtual List<SubPost> SubPosts { get; set; }
        public virtual AdminPanel adminPanel { get; set; }
        public virtual List<ImageGallery> imageGalleries { get; set; }
        #endregion


    }
}
