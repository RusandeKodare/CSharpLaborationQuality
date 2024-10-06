using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	internal class Geo
	{

		private string _lat { get; set; }
		private string _lng { get; set; }

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
