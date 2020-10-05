using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class SubPostDescription
    {
        public SubPostDescription()
        {

        }
        public int SubPostDescriptionId { get; set; }
        public string Text { get; set; }
        public string imageName { get; set; }
        public string Images { get; set; }
        public int SubPostId { get; set; }
        public string LanguageTitle { get; set; }
        #region Relations
        [ForeignKey("SubPostId")]
        public virtual SubPost SubPost { get; set; }
        #endregion
    }
}
