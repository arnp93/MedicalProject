using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class SubPost
    {
        public SubPost()
        {

        }
        public int SubPostId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
        public string Images { get; set; }
        public string TextResumen { get; set; }
        public int PostId { get; set; }
        public string LanguageTitle { get; set; }

        #region Relations
        public virtual SubPostDescription subPostDescription { get; set; }
        public virtual Post post { get; set; }
        
        #endregion

    }
}
