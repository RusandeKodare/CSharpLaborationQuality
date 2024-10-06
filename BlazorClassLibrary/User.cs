using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class User
	{
		public int Id { get; set; } = 0;
		public string Name { get; set; } = "1234";
		public string UserName { get; set; } = "1234";
		public string Email { get; set; } = "1234";
		public string Phone { get; set; } = "1234";
		public string Website { get; set; } = "1234";
		public Address Address { get; set; } = new Address();
		public Company Company { get; set; } = new Company();

		public User(int id, string name, string userName, string email, string phone, string website, Address address, Company company)
		{
			Id = id;
			Name = name;
			UserName = userName;
			Email = email;
			Phone = phone;
			Website = website;
			Address = address;
			Company = company;
		}

		public User()
		{

		}
		
			
		
	}
}
