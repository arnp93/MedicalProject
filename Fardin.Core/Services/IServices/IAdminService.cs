using Fardin.DataLayer.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fardin.Core.Services.IServices
{
    public interface IAdminService
    {
        AdminPanel returnAdmin(string username, string password);
    }
}
