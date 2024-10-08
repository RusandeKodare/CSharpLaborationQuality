using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class Geo
	{

		public string Lat { get; set; } = "";
		public string Lng { get; set; } = "";

		public Geo(string lat, string lng)
		{
			Lat = lat;
			Lng = lng;
		}

		public Geo()
		{

		}
	}
}
