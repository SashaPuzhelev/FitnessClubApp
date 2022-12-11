using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessClubApp
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static User[] GetUsers()
        {
            return new User[] {
                new User() { Login = "Менеджер", Password = "Менеджер" },
                new User() { Login = "Админ", Password = "Админ" }
            };
        }
    }
}
