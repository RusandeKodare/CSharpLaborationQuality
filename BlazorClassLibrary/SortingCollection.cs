using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class SortingCollection
	{

		public List<User> SortByName(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(movie => movie.Name).ToList();
			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(movie => movie.Name).ToList();
				return users;
			}
				users = users.OrderBy(movie => movie.Name).ToList();
				return users;
		}

		public List<User> SortByID(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(movie => movie.Id).ToList();

			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(movie => movie.Id).ToList();
				return users;
			}
			users = users.OrderBy(movie => movie.Id).ToList();
			return users;
		}
	}
}
