﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using BlazorClassLibrary.Services;
namespace BlazorClassLibrary
{
	public class User
	{
		public int Id { get; set; } = 0;
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Name has to be at least 2 letters long")]
        [RegularExpression("^[a-zA-Z ]+$", ErrorMessage = "Name can only contain letters.")]
        public string Name { get; set; } = "";
		[Required]
		[Range(18, 120)]
		public int? Age { get; set; } = null;
		[StringLength(20)]
		[RegularExpression("^[a-zA-Z]+$", ErrorMessage = "User name can only contain letters with no space.")]
		[Required]
		public string UserName { get; set; } = "";
		[Required]
		[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Invalid email format.")]
		public string Email { get; set; } = "";
		public string Phone { get; set; } = "";
		public string Website { get; set; } = "";
		public Address Address { get; set; } = new Address();
		public Company Company { get; set; } = new Company();
		public TodoService TodoService { get; set; } = new();
		public User(int id, string name, int age, string userName, string email, string phone, string website, Address address, Company company, TodoService todoService)
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
			TodoService = todoService;
        }
		public User(){}
	}
}
