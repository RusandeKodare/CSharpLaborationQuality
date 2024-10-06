using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	internal class User
	{
		private int _id { get; set; }
		private string _name { get; set; }
		private string _userName { get; set; }
		private string _email { get; set; }
		private string _phone { get; set; }
		private string _website { get; set; }
		private Address Address { get; set; }
		private Company Company { get; set; }

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
