using Fardin.Core.DTO;
using Fardin.DataLayer.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.Services.IServices
{
    public interface IAdminService
    {
        AdminPanel returnAdmin(string username, string password);
        SocialNetwork returnSocialNetwork();
        void addSocialNetworks(SocialNetwork socialNetwork);
        SocialNetwork getSocialNetworks();

        void addAbout(string text);
        About getAbout();

        void ChangePassword(ChangePasswordViewModel ChangePasswordViewModel);
    }
}
