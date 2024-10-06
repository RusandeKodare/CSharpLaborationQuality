using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	internal class Address
	{

		private string _street { get; set; }
		private string _suite { get; set; }
		private string _city { get; set; }
		private string _zipcode { get; set; }
		private Geo Geo { get; set; }

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
