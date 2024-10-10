using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorClassLibrary
{
	public class User
	{
		public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
		public int? Age { get; set; } = null;
		public string UserName { get; set; } = "";
		public string Email { get; set; } = "";
		public string Phone { get; set; } = "";
		public string Website { get; set; } = "";
		public Address Address { get; set; } = new Address();
		public Company Company { get; set; } = new Company();
		public User(int id, string name, int age, string userName, string email, string phone, string website, Address address, Company company)
		{
			Id = id;
			Name = name;
            Age = age;
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
