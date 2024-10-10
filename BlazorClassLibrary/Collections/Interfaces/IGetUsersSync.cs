using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections.Interfaces
{
    internal interface IGetUsersSync
    {
        public List<User> GetUsers();
    }
}
