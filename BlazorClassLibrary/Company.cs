using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	internal class Company
	{

		private string _name { get; set; }
		private string _catchPhrase { get; set; }
		private string _bs { get; set; }

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
