using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using BlazorClassLibrary.Collections.Interfaces;

namespace BlazorClassLibrary.Collections
{
    public class ApiCollection : ICollections
	{
		public List<User> Users { get; set; } = [];
		public HttpClient _httpClient = new();

		public async Task<List<User>> GetUsers()
		{
			Users = await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users")?? [];
			if (Users != null)
			{
				return Users;
			}
			return [];
		}

		public void AddUser(User user)
		{
			Users.Add(user);
        }

      
    }
}
