using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
	public class InternalDataBase : ICollections
	{
		public List<User> Users { get; set; } = new List<User>();

		public List<User> GetUser()
		{
			throw new NotImplementedException();
		}

		public List<User> GetAllUsers()
		{
			throw new NotImplementedException();
		}
	}
	
}
