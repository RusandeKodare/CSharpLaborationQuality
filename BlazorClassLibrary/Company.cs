using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class Company
	{

		private string _name { get; set; } = "1234";
		private string _catchPhrase { get; set; } = "1234";
		private string _bs { get; set; } = "1234";

		public Company(string name, string catchPhrase, string bs)
		{
			_name = name;
			_catchPhrase = catchPhrase;
			_bs = bs;
		}

		public Company()
		{

		}
	}
}
