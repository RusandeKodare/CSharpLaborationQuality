using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections.Interfaces
{
    public interface ILocalDataAccess
    {
        public List<User> Users { get; set; }

        public List<User> GetUsers();

        public List<User> GetUsersFromInternalDb();
    }
}
