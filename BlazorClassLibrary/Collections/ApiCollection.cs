﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace BlazorClassLibrary.Collections
{
	public class ApiCollection : ICollections
	{
		public List<User> Users { get; set; } = new List<User>();
		public HttpClient _httpClient = new HttpClient();

		public async Task<List<User>> GetUsers()
		{
			Users = await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");
			if (Users != null)
			{
				return Users;
			}
			return [];
		}

		public List<User> GetAllUsers()
		{
			throw new NotImplementedException();
		}

		List<User> ICollections.GetUser(string user)
		{
			throw new NotImplementedException();
		}
	}
}
