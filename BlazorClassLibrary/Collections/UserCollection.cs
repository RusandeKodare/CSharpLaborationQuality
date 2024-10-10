﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
	public class UserCollection : ICollections
    {
		public List<User> Users { get; set; } = [];
        public void AddUser(User user)
        {
			Users.Add(user);
		}

		public void SaveList()
		{
			string? groupJson = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText("List_Of_People_Save.json", groupJson);
		}

        public List<User> GetUsers()
        {
			if (File.Exists("List_Of_People_Save.json"))
			{
				var loadedJson = File.ReadAllText("List_Of_People_Save.json");
				Users = JsonSerializer.Deserialize<List<User>>(loadedJson) ?? [];
				return Users;
			}

			else
			{
				return [];
            }
           
		}
		public List<User> GetUsersFromApi()
		{

			InternalDBCollection internalDBCollection = new InternalDBCollection();
			Users = internalDBCollection.GetUsers();
			return Users;
		}
    }
}
