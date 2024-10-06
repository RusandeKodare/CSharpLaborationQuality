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
		private int _id { get; set; } = 0;
		private string _name { get; set; } = "1234";
		private string _userName { get; set; } = "1234";
		private string _email { get; set; } = "1234";
		private string _phone { get; set; } = "1234";
		private string _website { get; set; } = "1234";
		private Address Address { get; set; } = new Address();
		private Company Company { get; set; } = new Company();

		public User(int id, string name, string userName, string email, string phone, string website, Address address, Company company)
		{
			_id = id;
			_name = name;
			_userName = userName;
			_email = email;
			_phone = phone;
			_website = website;
			Address = address;
			Company = company;
		}

		public User()
		{

		}
		
			
		
	}
}
