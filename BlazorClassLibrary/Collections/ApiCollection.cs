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
    public class ApiCollection : IRemoteDataAccess
    {
		public HttpClient _httpClient = new();

		public async Task<List<User>> GetUsers()
		{
			try
			{
                return await _httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users") ?? [];
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching users.", ex);
            }
			
		}
    }
}
