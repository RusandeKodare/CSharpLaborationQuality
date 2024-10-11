using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using BlazorClassLibrary.Collections.Interfaces;

namespace BlazorClassLibrary.Collections
{
	public class InternalDBCollection : ICollections, IGetUsersSync
	{
		public List<User> Users { get; set; } = new List<User>
			{
				new User
				{
					Id = 1,
					Name = "Simba Lion",
					UserName = "SimbaLion",
					Email = "simba.lion@pride.com",
					Age = 5,
					Address = new Address
					{
						Street = "Pride Rock",
						City = "Savanna",
						ZipCode = "00001"
					},
					Company = new Company
					{
						Name = "Circle of Life Co.",
						CatchPhrase = "Hakuna Matata"
					}
				},
				new User
				{
					Id = 2,
					Name = "Elsa Arendelle",
					UserName = "ElsaArendelle",
					Email = "elsa.arendelle@frozen.com",
					Age = 25,
					Address = new Address
					{
						Street = "Ice Palace",
						City = "Arendelle",
						ZipCode = "30303"
					},
					Company = new Company
					{
						Name = "Frozen Enterprises",
						CatchPhrase = "Let It Go"
					}
				},
				new User
				{
					Id = 3,
					Name = "Woody Cowboy",
					UserName = "WoodyCowboy",
					Email = "woody.cowboy@toybox.com",
					Age = 30,
					Address = new Address
					{
						Street = "Andy's Room",
						City = "Toyland",
						ZipCode = "12345"
					},
					Company = new Company
					{
						Name = "Toybox LLC",
						CatchPhrase = "You've Got a Friend in Me"
					}
				},
				new User
				{
					Id = 4,
					Name = "Buzz Lightyear",
					UserName = "BuzzLightyear",
					Email = "buzz.lightyear@space.com",
					Age = 32,
					Address = new Address
					{
						Street = "Star Command",
						City = "Infinity",
						ZipCode = "67890"
					},
					Company = new Company
					{
						Name = "Galactic Defenders",
						CatchPhrase = "To Infinity and Beyond"
					}
				},
				new User
				{
					Id = 5,
					Name = "Mickey Mouse",
					UserName = "MickeyMouse",
					Email = "mickey.mouse@disney.com",
					Age = 93,
					Address = new Address
					{
						Street = "Main Street",
						City = "Disneyland",
						ZipCode = "12345"
					},
					Company = new Company
					{
						Name = "Disney Inc.",
						CatchPhrase = "Oh Boy!"
					}
				},
				new User
				{
					Id = 6,
					Name = "Donald Duck",
					UserName = "DonaldDuck",
					Email = "donald.duck@disney.com",
					Age = 88,
					Address = new Address
					{
						Street = "Duckburg",
						City = "Duckburg",
						ZipCode = "67890"
					},
					Company = new Company
					{
						Name = "Duck Enterprises",
						CatchPhrase = "Aw, Phooey!"
					}
				},
				new User
				{
					Id = 7,
					Name = "Ariel Mermaid",
					UserName = "ArielMermaid",
					Email = "ariel.mermaid@ocean.com",
					Age = 18,
					Address = new Address
					{
						Street = "Undersea Castle",
						City = "Atlantica",
						ZipCode = "10234"
					},
					Company = new Company
					{
						Name = "Ocean Enterprises",
						CatchPhrase = "Part of Your World"
					}
				},
				new User
				{
					Id = 8,
					Name = "Peter Pan",
					UserName = "PeterPan",
					Email = "peter.pan@neverland.com",
					Age = 16,
					Address = new Address
					{
						Street = "Lost Boys Hideout",
						City = "Neverland",
						ZipCode = "20456"
					},
					Company = new Company
					{
						Name = "Neverland Ventures",
						CatchPhrase = "Never Grow Up"
					}
				},
				new User
				{
					Id = 9,
					Name = "Cinderella Princess",
					UserName = "CinderellaPrincess",
					Email = "cinderella.princess@fairytale.com",
					Age = 22,
					Address = new Address
					{
						Street = "Royal Castle",
						City = "Kingdom",
						ZipCode = "30567"
					},
					Company = new Company
					{
						Name = "Royal Dreams",
						CatchPhrase = "A Dream is a Wish Your Heart Makes"
					}
				},
				new User
				{
					Id = 10,
					Name = "Mulan Warrior",
					UserName = "MulanWarrior",
					Email = "mulan.warrior@china.com",
					Age = 28,
					Address = new Address
					{
						Street = "Imperial Palace",
						City = "China",
						ZipCode = "40678"
					},
					Company = new Company
					{
						Name = "Warrior Enterprises",
						CatchPhrase = "I'll Make a Man Out of You"
					}
				},
				new User
				{
					Id = 11,
					Name = "Tiana Frog",
					UserName = "TianaFrog",
					Email = "tiana.frog@nola.com",
					Age = 26,
					Address = new Address
					{
						Street = "Bayou Lane",
						City = "New Orleans",
						ZipCode = "50689"
					},
					Company = new Company
					{
						Name = "Frog Enterprises",
						CatchPhrase = "Almost There"
					}
				},
				new User
				{
					Id = 12,
					Name = "Rapunzel Tangled",
					UserName = "RapunzelTangled",
					Email = "rapunzel.tangled@tower.com",
					Age = 19,
					Address = new Address
					{
						Street = "Tower Heights",
						City = "Corona",
						ZipCode = "60790"
					},
					Company = new Company
					{
						Name = "Hair Care Inc.",
						CatchPhrase = "Let Your Hair Down"
					}
				},
				new User
				{
					Id = 13,
					Name = "Aladdin Thief",
					UserName = "AladdinThief",
					Email = "aladdin.thief@agrabah.com",
					Age = 22,
					Address = new Address
					{
						Street = "Market Street",
						City = "Agrabah",
						ZipCode = "70801"
					},
					Company = new Company
					{
						Name = "Genie Enterprises",
						CatchPhrase = "A Whole New World"
					}
				},
				new User
				{
					Id = 14,
					Name = "Belle Beauty",
					UserName = "BelleBeauty",
					Email = "belle.beauty@france.com",
					Age = 24,
					Address = new Address
					{
						Street = "Beast Castle",
						City = "Provincial Town",
						ZipCode = "80912"
					},
					Company = new Company
					{
						Name = "Enchanted Services",
						CatchPhrase = "Beauty and the Beast"
					}
				},
				new User
				{
					Id = 15,
					Name = "Tarzan Jungle",
					UserName = "TarzanJungle",
					Email = "tarzan.jungle@jungle.com",
					Age = 30,
					Address = new Address
					{
						Street = "Treehouse Lane",
						City = "Jungle",
						ZipCode = "90123"
					},
					Company = new Company
					{
						Name = "Vine Ventures",
						CatchPhrase = "Son of Man"
					}
				},
				new User
				{
					Id = 16,
					Name = "Moana Wayfinder",
					UserName = "MoanaWayfinder",
					Email = "moana.wayfinder@oceania.com",
					Age = 18,
					Address = new Address
					{
						Street = "Ocean Drive",
						City = "Motunui",
						ZipCode = "10234"
					},
					Company = new Company
					{
						Name = "Wayfinding Enterprises",
						CatchPhrase = "How Far I'll Go"
					}
				},
				new User
				{
					Id = 17,
					Name = "Pocahontas Nature",
					UserName = "PocahontasNature",
					Email = "pocahontas.nature@tribe.com",
					Age = 21,
					Address = new Address
					{
						Street = "Forest Path",
						City = "Powhatan",
						ZipCode = "20345"
					},
					Company = new Company
					{
						Name = "Spirit of the Wind",
						CatchPhrase = "Colors of the Wind"
					}
				},
				new User
				{
					Id = 18,
					Name = "Goofy Goof",
					UserName = "GoofyGoof",
					Email = "goofy.goof@disney.com",
					Age = 37,
					Address = new Address
					{
						Street = "Goof Street",
						City = "Spoonerville",
						ZipCode = "90909"
					},
					Company = new Company
					{
						Name = "Goofy Enterprises",
						CatchPhrase = "Gawrsh!"
					}
				},
				new User
				{
					Id = 19,
					Name = "Aurora Rose",
					UserName = "AuroraRose",
					Email = "aurora.rose@castle.com",
					Age = 26,
					Address = new Address
					{
						Street = "Briar Woods",
						City = "Fairy Kingdom",
						ZipCode = "20356"
					},
					Company = new Company
					{
						Name = "Royal Dreams Inc.",
						CatchPhrase = "Once Upon a Dream"
					}
				},
				new User
				{
					Id = 20,
					Name = "Jasmine Agrabah",
					UserName = "JasmineAgrabah",
					Email = "jasmine.agrabah@palace.com",
					Age = 24,
					Address = new Address
					{
						Street = "Royal Palace",
						City = "Agrabah",
						ZipCode = "40789"
					},
					Company = new Company
					{
						Name = "Magic Carpet Co.",
						CatchPhrase = "A Whole New World"
					}
				},
				new User
				{
					Id = 21,
					Name = "Hercules Hero",
					UserName = "HerculesHero",
					Email = "hercules.hero@olympus.com",
					Age = 28,
					Address = new Address
					{
						Street = "Mount Olympus",
						City = "Olympus",
						ZipCode = "50890"
					},
					Company = new Company
					{
						Name = "Hero for Hire",
						CatchPhrase = "Go the Distance"
					}
				},
				new User
				{
					Id = 22,
					Name = "Merida Brave",
					UserName = "MeridaBrave",
					Email = "merida.brave@highlands.com",
					Age = 21,
					Address = new Address
					{
						Street = "Stone Circle",
						City = "DunBroch",
						ZipCode = "60901"
					},
					Company = new Company
					{
						Name = "Clan Brave Ltd.",
						CatchPhrase = "Fate Be Changed"
					}
				},
				new User
				{
					Id = 23,
					Name = "Stitch Alien",
					UserName = "StitchAlien",
					Email = "stitch.alien@hawaii.com",
					Age = 5,
					Address = new Address
					{
						Street = "Experiment Road",
						City = "Kauai",
						ZipCode = "10234"
					},
					Company = new Company
					{
						Name = "Ohana Services",
						CatchPhrase = "Ohana Means Family"
					}
				},
				new User
				{
					Id = 24,
					Name = "Alice Wonderland",
					UserName = "AliceWonderland",
					Email = "alice.wonderland@rabbit.com",
					Age = 19,
					Address = new Address
					{
						Street = "Madhatter Lane",
						City = "Wonderland",
						ZipCode = "10345"
					},
					Company = new Company
					{
						Name = "Wonderland Ventures",
						CatchPhrase = "Curioser and Curioser"
					}
				},
				new User
				{
					Id = 25,
					Name = "Tinkerbell Fairy",
					UserName = "TinkerbellFairy",
					Email = "tinkerbell.fairy@pixie.com",
					Age = 22,
					Address = new Address
					{
						Street = "Pixie Hollow",
						City = "Neverland",
						ZipCode = "30456"
					},
					Company = new Company
					{
						Name = "Pixie Dust Inc.",
						CatchPhrase = "Faith, Trust, and Pixie Dust"
					}
				}
			};



		public List<User> GetUsers()
		{
			return Users;
		}

		public void AddUser(User user)
		{
			Users.Add(user);
		}
	}
}
