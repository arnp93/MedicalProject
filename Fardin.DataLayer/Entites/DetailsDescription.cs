using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class DetailsDescription
    {
        public DetailsDescription()
        {

        }
        public int DetailsDescriptionId { get; set; }
        public string Text { get; set; }
        public string imageName { get; set; }
        public string videoName { get; set; }
        public int PostDetailsId { get; set; }

        #region Relations
        public virtual PostDetail postDetail { get; set; }
        #endregion
    }
}
