using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class Address
	{

		private string _street { get; set; } = "1234";
		private string _suite { get; set; } = "1234";
		private string _city { get; set; } = "1234";
		private string _zipcode { get; set; } = "1234";
		private Geo Geo { get; set; } = new Geo();

		public Address(string street, string suite, string city, string zipcode, Geo geo)
		{
			_street = street;
			_suite = suite;
			_city = city;
			_zipcode = zipcode;
			Geo = geo;
		}

		public Address()
		{

		}
	}
}
