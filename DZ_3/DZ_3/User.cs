using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public static ObservableCollection<User> GetUser()
        {
            var userList = new ObservableCollection<User>()
            {
                new User()
                {
                    Login = "Maga",
                    Password = "Maga"
                },

                new User()
                {
                    Login = "admin",
                    Password = "admin"
                },
            };

            return userList;
        }
    }
}
