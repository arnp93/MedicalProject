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

        public AdminPanel returnAdmin(string username, string password)
        {
            return _db.admins.SingleOrDefault(a => a.Username == username && a.Password == PasswordHelper.EncodePasswordMd5(password));
        }
    }
}
