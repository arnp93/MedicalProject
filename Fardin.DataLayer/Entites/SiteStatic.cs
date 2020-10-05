using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.DataLayer.Entites
{
    public class SiteStatic
    {
        public int SiteStaticId { get; set; }
        public string LanguageTitle { get; set; }

        #region Footer Section
        public string FooterImageName { get; set; }
        public string MiniTitle { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        #endregion

        #region Cover Section
        public string CoverImageName { get; set; }
        #endregion
    }
}
