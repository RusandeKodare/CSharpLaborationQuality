using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
	public interface ICollections
	{
		public List<User> Users { get; set; }

		public List<User> GetUsers();
		public void AddUser(User user);



	}
}
