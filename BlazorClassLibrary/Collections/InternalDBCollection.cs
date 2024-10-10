using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                        Name = "Leanne Graham",
                        Email = "Leanne.Graham@hotmail.com",
                        Age = 25,
                        Address = new Address
                        {
                            Street = "Kulas Light",
                            City = "Gwenborough",
                            ZipCode = "92998-3874"
                        },
                        Company = new Company
                        {
                            Name = "Romaguera-Crona",
                            CatchPhrase = "Multi-layered client-server neural-net"
                        }
                    },
                    new User
                    {
                        Id = 2,
                        Name = "Ervin Howell",
                        Email = "Ervin.Howell@outlook.se",
                        Age = 25,
                        Address = new Address
                        {
                            Street = "Victor Plains",
                            City = "Wisokyburgh",
                            ZipCode = "90566-7771"
                        },
                        Company = new Company
                        {
                            Name = "Deckow-Crist",
                            CatchPhrase = "Proactive didactic contingency"
                        }
                    },
                    new User
                    {
                        Id = 3,
                        Name = "Clementine Bauch",
                        Email = "Clementine.Bauch@gmail.com",
                        Age = 30,
                        Address = new Address
                        {
                            Street = "Douglas Extension",
                            City = "McKenziehaven",
                            ZipCode = "59590-4157"
                        },
                        Company = new Company
                        {
                            Name = "Romaguera-Jacobson",
                            CatchPhrase = "Face to face bifurcated interface"
                        }
                    },
                    new User
                    {
                        Id = 4,
                        Name = "Patricia Lebsack",
                        Email = "Patricia.Lebsack@kory.org",
                        Age = 35,
                        Address = new Address
                        {
                            Street = "Hoeger Mall",
                            City = "South Elvis",
                            ZipCode = "53919-4257"
                        },
                        Company = new Company
                        {
                            Name = "Robel-Corkery",
                            CatchPhrase = "Multi-tiered zero tolerance productivity"
                        }
                    },
                    new User
                    {
                        Id = 5,
                        Name = "Chelsey Dietrich",
                        Email = "Chelsey.Dietrich@annie.ca",
                        Age = 28,
                        Address = new Address
                        {
                            Street = "Skiles Walks",
                            City = "Roscoeview",
                            ZipCode = "33263"
                        },
                        Company = new Company
                        {
                            Name = "Keebler LLC",
                            CatchPhrase = "User-centric fault-tolerant solution"
                        }
                    },
                    new User
                    {
                        Id = 6,
                        Name = "Mrs. Dennis Schulist",
                        Email = "Dennis.Schulist@jasper.info",
                        Age = 40,
                        Address = new Address
                        {
                            Street = "Norberto Crossing",
                            City = "South Christy",
                            ZipCode = "23505-1337"
                        },
                        Company = new Company
                        {
                            Name = "Considine-Lockman",
                            CatchPhrase = "Synchronised bottom-line interface"
                        }
                    },
                    new User
                    {
                        Id = 7,
                        Name = "Kurtis Weissnat",
                        Email = "Kurtis.Weissnat@billy.biz",
                        Age = 32,
                        Address = new Address
                        {
                            Street = "Rex Trail",
                            City = "Howemouth",
                            ZipCode = "58804-1099"
                        },
                        Company = new Company
                        {
                            Name = "Johns Group",
                            CatchPhrase = "Configurable multimedia task-force"
                        }
                    },
                    new User
                    {
                        Id = 8,
                        Name = "Nicholas Runolfsdottir V",
                        Email = "Nicholas.Runo@rosamond.me",
                        Age = 36,
                        Address = new Address
                        {
                            Street = "Ellsworth Summit",
                            City = "Aliyaview",
                            ZipCode = "45169"
                        },
                        Company = new Company
                        {
                            Name = "Abernathy Group",
                            CatchPhrase = "Implemented secondary concept"
                        }
                    },
                    new User
                    {
                        Id = 9,
                        Name = "Glenna Reichert",
                        Email = "Glenna.Reichert@dana.io",
                        Age = 27,
                        Address = new Address
                        {
                            Street = "Dayna Park",
                            City = "Bartholomebury",
                            ZipCode = "76495-3109"
                        },
                        Company = new Company
                        {
                            Name = "Yost and Sons",
                            CatchPhrase = "Switchable contextually-based project"
                        }
                    },
                    new User
                    {
                        Id = 10,
                        Name = "Clementina DuBuque",
                        Email = "Clementina.DuBuque@karina.biz",
                        Age = 31,
                        Address = new Address
                        {
                            Street = "Kattie Turnpike",
                            City = "Lebsackbury",
                            ZipCode = "31428-2261"
                        },
                        Company = new Company
                        {
                            Name = "Hoeger LLC",
                            CatchPhrase = "Centralized empowering task-force"
                        }
                    },
                    new User
                    {
                        Id = 11,
                        Name = "Leanne Graham",
                        Email = "Leanne.Graham@hotmail.com",
                        Age = 25,
                        Address = new Address
                        {
                            Street = "Kulas Light",
                            City = "Gwenborough",
                            ZipCode = "92998-3874"
                        },
                        Company = new Company
                        {
                            Name = "Romaguera-Crona",
                            CatchPhrase = "Multi-layered client-server neural-net"
                        }
                    },
                    new User
                    {
                        Id = 12,
                        Name = "Ervin Howell",
                        Email = "Ervin.Howell@outlook.se",
                        Age = 25,
                        Address = new Address
                        {
                            Street = "Victor Plains",
                            City = "Wisokyburgh",
                            ZipCode = "90566-7771"
                        },
                        Company = new Company
                        {
                            Name = "Deckow-Crist",
                            CatchPhrase = "Proactive didactic contingency"
                        }
                    },
                    new User
                    {
                        Id = 13,
                        Name = "John Doe",
                        Email = "john.doe@example.com",
                        Age = 30,
                        Address = new Address
                        {
                            Street = "Main Street",
                            City = "New York",
                            ZipCode = "10001"
                        },
                        Company = new Company
                        {
                            Name = "ABC Company",
                            CatchPhrase = "Innovative solutions"
                        }
                    },
                    new User
                    {
                        Id = 14,
                        Name = "Jane Smith",
                        Email = "jane.smith@example.com",
                        Age = 35,
                        Address = new Address
                        {
                            Street = "Oak Avenue",
                            City = "Los Angeles",
                            ZipCode = "90001"
                        },
                        Company = new Company
                        {
                            Name = "XYZ Corporation",
                            CatchPhrase = "Driving success"
                        }
                    },
                    new User
                    {
                        Id = 15,
                        Name = "Michael Johnson",
                        Email = "michael.johnson@example.com",
                        Age = 28,
                        Address = new Address
                        {
                            Street = "Pine Street",
                            City = "Chicago",
                            ZipCode = "60601"
                        },
                        Company = new Company
                        {
                            Name = "123 Industries",
                            CatchPhrase = "Innovating the future"
                        }
                    },
                    new User
                    {
                        Id = 16,
                        Name = "Emily Davis",
                        Email = "emily.davis@example.com",
                        Age = 40,
                        Address = new Address
                        {
                            Street = "Cedar Road",
                            City = "Seattle",
                            ZipCode = "98101"
                        },
                        Company = new Company
                        {
                            Name = "XYZ Corporation",
                            CatchPhrase = "Driving success"
                        }
                    },
                    new User
                    {
                        Id = 17,
                        Name = "David Wilson",
                        Email = "david.wilson@example.com",
                        Age = 32,
                        Address = new Address
                        {
                            Street = "Maple Avenue",
                            City = "San Francisco",
                            ZipCode = "94101"
                        },
                        Company = new Company
                        {
                            Name = "ABC Company",
                            CatchPhrase = "Innovative solutions"
                        }
                    },
                    new User
                    {
                        Id = 18,
                        Name = "Olivia Thompson",
                        Email = "olivia.thompson@example.com",
                        Age = 36,
                        Address = new Address
                        {
                            Street = "Elm Street",
                            City = "Boston",
                            ZipCode = "02101"
                        },
                        Company = new Company
                        {
                            Name = "123 Industries",
                            CatchPhrase = "Innovating the future"
                        }
                    },
                    new User
                    {
                        Id = 19,
                        Name = "James Anderson",
                        Email = "james.anderson@example.com",
                        Age = 27,
                        Address = new Address
                        {
                            Street = "Spruce Lane",
                            City = "Dallas",
                            ZipCode = "75201"
                        },
                        Company = new Company
                        {
                            Name = "XYZ Corporation",
                            CatchPhrase = "Driving success"
                        }
                    },
                    new User
                    {
                        Id = 20,
                        Name = "Sophia Martinez",
                        Email = "sophia.martinez@example.com",
                        Age = 31,
                        Address = new Address
                        {
                            Street = "Birch Street",
                            City = "Houston",
                            ZipCode = "77001"
                        },
                        Company = new Company
                        {
                            Name = "ABC Company",
                            CatchPhrase = "Innovative solutions"
                        }
                    },
                    new User
                    {
                        Id = 21,
                        Name = "Alexander Clark",
                        Email = "alexander.clark@example.com",
                        Age = 25,
                        Address = new Address
                        {
                            Street = "Willow Drive",
                            City = "Atlanta",
                            ZipCode = "30301"
                        },
                        Company = new Company
                        {
                            Name = "123 Industries",
                            CatchPhrase = "Innovating the future"
                        }
                    },
                    new User
                    {
                        Id = 22,
                        Name = "Mia Rodriguez",
                        Email = "mia.rodriguez@example.com",
                        Age = 25,
                        Address = new Address
                        {
                            Street = "Hickory Lane",
                            City = "Miami",
                            ZipCode = "33101"
                        },
                        Company = new Company
                        {
                            Name = "XYZ Corporation",
                            CatchPhrase = "Driving success"
                        }
                    },
                    new User
                    {
                        Id = 23,
                        Name = "William Baker",
                        Email = "william.baker@example.com",
                        Age = 30,
                        Address = new Address
                        {
                            Street = "Chestnut Street",
                            City = "Philadelphia",
                            ZipCode = "19101"
                        },
                        Company = new Company
                        {
                            Name = "ABC Company",
                            CatchPhrase = "Innovative solutions"
                        }
                    },
                    new User
                    {
                        Id = 24,
                        Name = "Sofia Hernandez",
                        Email = "sofia.hernandez@example.com",
                        Age = 35,
                        Address = new Address
                        {
                            Street = "Sycamore Lane",
                            City = "Phoenix",
                            ZipCode = "85001"
                        },
                        Company = new Company
                        {
                            Name = "123 Industries",
                            CatchPhrase = "Innovating the future"
                        }
                    },
                    new User
                    {
                        Id = 25,
                        Name = "Benjamin Green",
                        Email = "benjamin.green@example.com",
                        Age = 28,
                        Address = new Address
                        {
                            Street = "Oak Street",
                            City = "Denver",
                            ZipCode = "80201"
                        },
                        Company = new Company
                        {
                            Name = "XYZ Corporation",
                            CatchPhrase = "Driving success"
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
