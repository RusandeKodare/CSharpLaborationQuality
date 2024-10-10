using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorClassLibrary.Collections
{
	public class InternalDBCollection : ICollections
	{


		public List<User> Users { get; set; }

		public List<User> GetUsers()
		{
			Users = new List<User>
			{
				new User(1, "Leanne Graham", "Leanne.Graham@hotmail.com", 25,
					new Address("Kulas Light", "Gwenborough", "92998-3874"),
					new Company("Romaguera-Crona", "Multi-layered client-server neural-net")),

				new User(2, "Ervin Howell", "Ervin.Howell@outlook.se", 25,
					new Address("Victor Plains", "Wisokyburgh", "90566-7771"),
					new Company("Deckow-Crist", "Proactive didactic contingency")),

				 new User(3, "John Smith", "john.smith@example.com", 30,
					new Address("Main Street", "New York", "10001"),
					new Company("ACME Inc.", "Leading provider of widgets")),

				 new User(4, "Jane Doe", "jane.doe@example.com", 28,
					 new Address("Elm Avenue", "Los Angeles", "90001"),
						new Company("XYZ Corp.", "Innovative solutions for the future")),

		new User(5, "Michael Brown", "michael.brown@example.com", 35,
			new Address("Oak Street", "Chicago", "60601"),
			new Company("Tech Solutions", "Empowering businesses with technology")),

		new User(6, "Emily Johnson", "emily.johnson@example.com", 32,
			new Address("Cedar Road", "Seattle", "98101"),
			new Company("Global Enterprises", "Connecting the world")),

		new User(7, "David Davis", "david.davis@example.com", 29,
			new Address("Pine Street", "San Francisco", "94101"),
			new Company("Innovate Inc.", "Driving innovation")),

		new User(8, "Sarah Wilson", "sarah.wilson@example.com", 27,
			new Address("Maple Avenue", "Boston", "02101"),
			new Company("Tech Solutions", "Empowering businesses with technology")),

		new User(9, "Robert Johnson", "robert.johnson@example.com", 33,
			new Address("Cherry Lane", "Dallas", "75201"),
			new Company("Global Enterprises", "Connecting the world")),

		new User(10, "John Doe", "john.doe@example.com", 30,
			new Address("Main Street", "New York", "10001"),
			new Company("ACME Inc.", "Leading provider of widgets")),

		new User(11, "Jane Smith", "jane.smith@example.com", 28,
			new Address("Elm Avenue", "Los Angeles", "90001"),
			new Company("XYZ Corp.", "Innovative solutions for the future")),

		new User(12, "Michael Johnson", "michael.johnson@example.com", 35,
			new Address("Oak Street", "Chicago", "60601"),
			new Company("Tech Solutions", "Empowering businesses with technology")),

		new User(13, "Emily Davis", "emily.davis@example.com", 32,
			new Address("Cedar Road", "Seattle", "98101"),
			new Company("Global Enterprises", "Connecting the world")),

		new User(14, "David Wilson", "david.wilson@example.com", 29,
			new Address("Pine Street", "San Francisco", "94101"),
			new Company("Innovate Inc.", "Driving innovation")),
				};

			return Users;
		}

		public void AddUser(User user)
		{
			Users.Add(user);
		}
	}
}
