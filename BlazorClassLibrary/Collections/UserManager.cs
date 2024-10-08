﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
	public class UserManager : ICollections
    {
		public List<User> Users { get; set; } = [];

		public void AddUser(User user)
        {
            Users.Add(user);
        }

        public void SaveUserToFile()
        {
			string? groupJson = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText("List_Of_People_Save.json", groupJson);
		}

        public List<User> GetUsersFromFile()
        {
			if (File.Exists("List_Of_People_Save.json"))
			{

				var loadedJson = File.ReadAllText("List_Of_People_Save.json");
				Users = JsonSerializer.Deserialize<List<User>>(loadedJson) ?? [];


				return Users ?? [];
			}


            return Users = new List<User>();
			
			
		}

		public List<User> GetUsers()
		{
			throw new NotImplementedException();
		}
	}
}
