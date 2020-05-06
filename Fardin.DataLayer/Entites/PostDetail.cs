using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class PostDetail
    {
        public PostDetail()
        {

        }
        public string PostDetailId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string TextResumen { get; set; }
        public int PostId { get; set; }

        #region Relations
        public virtual List<DetailsDescription> detailsDescriptions { get; set; }
        public virtual Post post { get; set; }
        #endregion

    }
}
