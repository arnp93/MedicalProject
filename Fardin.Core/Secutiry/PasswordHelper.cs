using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Fardin.Security
{
    public static class PasswordHelper
    {
        public static string EncodePasswordMd5(string pass) //Encrypt using MD5   
        {
            Byte[] originalBytes;
            Byte[] encodedBytes;
            SHA1 sha1;
            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)   
            sha1 = new SHA1CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(pass);
            encodedBytes = sha1.ComputeHash(originalBytes);
            string test = ASCIIEncoding.Default.GetString(encodedBytes);
            //Convert encoded bytes back to a 'readable' string   
            return BitConverter.ToString(encodedBytes);
        }
    }
}
