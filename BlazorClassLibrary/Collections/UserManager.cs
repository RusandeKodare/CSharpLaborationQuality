using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
    class UserManager : ICollections
    {
        public List<User> Users { get; set; }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void SaveUserToFile()
        {

        }

        public void LoadUserFromFile()
        {

        }
        public List<User> GetAllUsers()
        {
            return Users;
        }

    }
}
