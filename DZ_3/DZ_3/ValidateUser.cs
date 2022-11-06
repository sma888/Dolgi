using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace DZ_3
{
    public class ValidateUser
    {
        public bool Validate(ObservableCollection<User> users, string password, string login )
        {
            foreach(var user in users)
            {
                if (user.Login == login && user.Password == password) return true;
            }
            return false;
        }
    }
}
