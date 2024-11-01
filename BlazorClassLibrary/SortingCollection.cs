using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class SortingCollection
	{
		public List<User> SortByID(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(user => user.Id).ToList();

			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(user => user.Id).ToList();
				return users;
			}
			users = users.OrderBy(movie => movie.Id).ToList();
			return users;
		}
		public List<User> SortByName(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(user => user.Name).ToList();
			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(user => user.Name).ToList();
				return users;
			}
			users = users.OrderBy(user => user.Name).ToList();
			return users;
		}

		public List<User> SortByUserName(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(user => user.UserName).ToList();
			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(user => user.UserName).ToList();
				return users;
			}
			users = users.OrderBy(user => user.UserName).ToList();
			return users;
		}
		public List<User> SortByEmail(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(user => user.Email).ToList();
			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(user => user.Email).ToList();
				return users;
			}
			users = users.OrderBy(user => user.Email).ToList();
			return users;
		}
		public List<User> SortByCity(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(user => user.Address.City).ToList();
			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(user => user.Address.City).ToList();
				return users;
			}
			users = users.OrderBy(user => user.Address.City).ToList();
			return users;
		}
		public List<User> SortByCompanyName(List<User> users)
		{
			List<User> usersAscending = users.OrderBy(user => user.Company.Name).ToList();
			if (users.SequenceEqual(usersAscending))
			{
				users = users.OrderByDescending(user => user.Company.Name).ToList();
				return users;
			}
			users = users.OrderBy(user => user.Company.Name).ToList();
			return users;
		}
	}
}
