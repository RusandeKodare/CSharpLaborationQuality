using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections.Interfaces
{
    internal interface IGetUsersAsync
    {
        public Task<List<User>> GetUsers();
    }
}
