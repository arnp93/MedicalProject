using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class Post
    {
        public Post()
        {

        }
        public int PostId { get; set; }
        public int SectionId { get; set; }
        public string PostText { get; set; }
        public string Title { get; set; }
        public string PostImg { get; set; }
        public int AdminPanelId { get; set; }
        #region Relations
        public virtual List<PostDetail> postDetails { get; set; }
        public virtual AdminPanel adminPanel { get; set; }
        #endregion
    }
}
