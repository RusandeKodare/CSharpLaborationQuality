using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
	public class InternalDBCollection : ICollections
	{
		public List<User> Users { get; set; } = [];
		public List<User> GetUsers()
		{
			throw new NotImplementedException();
		}
		public void AddUser(User user)
		{
			throw new NotImplementedException();
		}

		
	}
}
