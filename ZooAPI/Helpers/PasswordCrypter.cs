using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ZooAPI.Repositories;
using ZooCore.Models;

namespace ZooAPI.Helpers
{
    public class PasswordCrypter
    {
        private readonly string _securityKey;
        public PasswordCrypter(string key)
        {
            _securityKey = key;
        }

        internal string EncryptPassword(string? password)
        {
            if (string.IsNullOrEmpty(password)) return "";
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + _securityKey));
        }
    }
}
