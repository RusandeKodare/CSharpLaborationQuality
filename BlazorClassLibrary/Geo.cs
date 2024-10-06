using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class Geo
	{

		private string _lat { get; set; } = "1234";
		private string _lng { get; set; } = "1234";

		public Geo(string lat, string lng)
		{
			_lat = lat;
			_lng = lng;
		}

		public Geo()
		{

		}
	}
}
