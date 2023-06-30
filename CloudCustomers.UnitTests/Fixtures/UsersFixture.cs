using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudCustomers.UnitTests.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                    new User
                    {
                        Id = 1,
                        Name = "Test",
                        Email = "teste@teste.com",
                        Address = new Address
                        {
                            City = "São Paulo",
                            Street = "Avenida Lincoln, 702",
                            ZipCode = "11706120"
                        }
                    },
                    new User
                    {
                        Id = 2,
                        Name = "John Doe",
                        Email = "johndoe@example.com",
                        Address = new Address
                        {
                            City = "New York",
                            Street = "123 Main Street",
                            ZipCode = "10001"
                        }
                    },
                    new User
                    {
                        Id = 3,
                        Name = "Jane Smith",
                        Email = "janesmith@example.com",
                        Address = new Address
                        {
                            City = "London",
                            Street = "456 Park Avenue",
                            ZipCode = "SW1A 1AA"
                        }
                    },
                    new User
                    {
                        Id = 4,
                        Name = "Alice Johnson",
                        Email = "alicejohnson@example.com",
                        Address = new Address
                        {
                            City = "Los Angeles",
                            Street = "789 Elm Street",
                            ZipCode = "90001"
                        }
                    },
                    new User
                    {
                        Id = 5,
                        Name = "Bob Anderson",
                        Email = "bobanderson@example.com",
                        Address = new Address
                        {
                            City = "Paris",
                            Street = "10 Rue de la Paix",
                            ZipCode = "75002"
                        }
                    },
                    new User
                    {
                        Id = 6,
                        Name = "Michael Brown",
                        Email = "michaelbrown@example.com",
                        Address = new Address
                        {
                            City = "Sydney",
                            Street = "15 George Street",
                            ZipCode = "2000"
                        }
                    },
                    new User
                    {
                        Id = 7,
                        Name = "Emily Davis",
                        Email = "emilydavis@example.com",
                        Address = new Address
                        {
                            City = "Tokyo",
                            Street = "20 Shibuya Street",
                            ZipCode = "150-0002"
                        }
                    },
                    new User
                    {
                        Id = 8,
                        Name = "David Wilson",
                        Email = "davidwilson@example.com",
                        Address = new Address
                        {
                            City = "Berlin",
                            Street = "30 Alexanderplatz",
                            ZipCode = "10178"
                        }
                    },
                    new User
                    {
                        Id = 9,
                        Name = "Olivia Martinez",
                        Email = "oliviamartinez@example.com",
                        Address = new Address
                        {
                            City = "Rome",
                            Street = "40 Via del Corso",
                            ZipCode = "00186"
                        }
                    },
                    new User
                    {
                        Id = 10,
                        Name = "Sophia Thompson",
                        Email = "sophiathompson@example.com",
                        Address = new Address
                        {
                            City = "Toronto",
                            Street = "50 Yonge Street",
                            ZipCode = "M5E 1J1"
                        }
                    }
            };
    }
}
