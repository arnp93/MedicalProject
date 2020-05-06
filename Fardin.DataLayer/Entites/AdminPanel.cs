using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.DataLayer.Entites
{
   public class AdminPanel
    {
        public AdminPanel()
        {

        }
        public int AdminPanelId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string imgName { get; set; }

        #region Relations
        public virtual List<Post> Posts { get; set; }
        #endregion
    }
}
