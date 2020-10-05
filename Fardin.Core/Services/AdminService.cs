using Fardin.Core.DTO;
using Fardin.DataLayer.Context;
using Fardin.DataLayer.Entites;
using Fardin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Fardin.Core.Services.IServices
{
    public class AdminService : IAdminService
    {
        private DatabaseContext _db;
        public AdminService(DatabaseContext context)
        {
            _db = context;
        }

        public void addAbout(string text)
        {
            About about = new About
            {
                Text = text,
                Date = DateTime.Now
            };
            _db.Abouts.Add(about);
            _db.SaveChanges();
        }

        public void addSocialNetworks(SocialNetwork socialNetwork)
        {
            SocialNetwork social = _db.socialNetworks.FirstOrDefault();
            if(social != null)
                _db.Remove(social);

            _db.socialNetworks.Add(socialNetwork);
            _db.SaveChanges();
        }

        public void ChangePassword(ChangePasswordViewModel ChangePasswordViewModel)
        {
            AdminPanel admin = _db.admins.Where(a => a.Password == PasswordHelper.EncodePasswordMd5(ChangePasswordViewModel.OldPassword)).FirstOrDefault();
            admin.Password = PasswordHelper.EncodePasswordMd5(ChangePasswordViewModel.NewPassword);
            _db.Update(admin);
            _db.SaveChanges();
        }

        public About getAbout()
        {
            return _db.Abouts.LastOrDefault();
        }

        public SocialNetwork getSocialNetworks()
        {
            return _db.socialNetworks.FirstOrDefault();
        }

        public AdminPanel returnAdmin(string username, string password)
        {
            return _db.admins.SingleOrDefault(a => a.Username == username && a.Password == PasswordHelper.EncodePasswordMd5(password));
        }

        public SocialNetwork returnSocialNetwork()
        {
            return _db.socialNetworks.LastOrDefault();
        }
    }
}
