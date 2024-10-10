using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary
{
	public class Company
	{

		public string Name { get; set; } = "";
		public string CatchPhrase { get; set; } = "";
		public string BS { get; set; } = "";

		public Company(string name, string catchPhrase, string bs)
		{
			Name = name;
			CatchPhrase = catchPhrase;
			BS = bs;
		}
		public Company(string name, string catchPhrase) :this(name, catchPhrase, "")
        {
			Name = name;
            CatchPhrase = catchPhrase;
        }
		public Company()
		{

		}
	}
}
