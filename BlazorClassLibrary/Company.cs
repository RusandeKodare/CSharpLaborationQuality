using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class Company
	{

		public string Name { get; set; } = "1234";
		public string CatchPhrase { get; set; } = "1234";
		public string BS { get; set; } = "1234";

		public Company(string name, string catchPhrase, string bs)
		{
			Name = name;
			CatchPhrase = catchPhrase;
			BS = bs;
		}

		public Company()
		{

		}
	}
}
