using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
	public class InternalDataBase : ICollections
	{
		public List<User> Users { get; set; } = [];
		public List<User> GetUser(string user)
		{
			throw new NotImplementedException();
		}
		public List<User> GetUsers()
		{
			throw new NotImplementedException();
		}
	}
}
