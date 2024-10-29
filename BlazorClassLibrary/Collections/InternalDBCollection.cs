using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using BlazorClassLibrary.Collections.Interfaces;

namespace BlazorClassLibrary.Collections
{
	public class InternalDBCollection : ICollections, IGetUsersSync
	{
		public List<User> Users { get; set; } = new List<User>();
		public List<User> GetUsers()
		{
			Users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("Internal_Db_List.json")) ?? [];
			return Users;
		}
		public void AddUser(User user)
		{
			Users.Add(user);
		}
	}
}
