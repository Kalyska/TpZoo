using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooCore.Models;

namespace ZooCore.Datas
{
    public static class InitialUser
    {
        private static string EncryptPassword(string password)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(password + "OSFc._OdUA4qfc#{QAbX"));
        }

        public static readonly List<User> zooUsers = new List<User>()
        {
            new User() { Id = 1, LastName="Abadi", FirstName="Ihab", Address="4 Avenue de l'Horizon 59650 Villeneuve d'Ascq", Email="iabadi@zooclemy.fr", PhoneNumber="0679486132", Password=EncryptPassword("SuperZ00++")},
            new User() { Id = 2, LastName="Doe", FirstName="John", Address="5 rue des Coquelicots 59650 Villeneuve d'Ascq", Email="jdoe@zooclemy.fr", PhoneNumber="0789543354", Password=EncryptPassword("0hlalaj'ai0ublié!")}
         };
    }
}
