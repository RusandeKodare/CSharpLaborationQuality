using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class Address
	{
		public string Street { get; set; } = "";
		public string Suite { get; set; } = "";
		public string City { get; set; } = "";
		public string ZipCode { get; set; } = "";
		public Geo Geo { get; set; } = new Geo();

		public Address(string street, string suite, string city, string zipcode, Geo geo)
		{
			Street = street;
			Suite = suite;
			City = city;
			ZipCode = zipcode;
			Geo = geo;
		}
		public Address(){}
	}
}
