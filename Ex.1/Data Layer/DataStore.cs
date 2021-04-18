using System.Collections.Generic;
using DataLayer.Model;
using System;

namespace DataLayer
{
    public sealed class DataStore
    {
        private static DataStore _instance;
        private static readonly object Padlock = new object();

        private DataStore()
        {
            SeedData();
        }

        public State State { get; set; }

        public static DataStore Instance
        {
            get
            {
                lock (Padlock)
                {
                    _instance ??= new DataStore();

                    return _instance;
                }
            }
        }

        private void SeedData()
        {
            State = new State(
                users: new List<User>
                {
                    new User
                    {
                        Email = "ablaszczyk@gmail.com", FirstName = "Adam", LastName = "Błaszczyk", Phone = "697851233"
                    },

                    new User
                    {
                        Email = "amatuszek@gmail.com", FirstName = "Antonina", LastName = "Matuszek", Phone = "663765245"
                    },

                    new User
                    {
                        Email = "zaliczeniena5@gmail.com", FirstName = "Etap", LastName = "Pierwszy", Phone = "555555555"
                    }
                },
                books: new List<Book>
                {
                    new Book
                    {
                        AuthorFN = "Stephen",
                        AuthorLN = "King",
                        Title = "Cmętarz zwieżąt",
                        Genre = "Horror",
                        Price = 26.99m,
                        Publisher = "Prószyński Media",
                        Pages = 276,
                        ReleaseDate = new DateTime(2009, 05, 12),
                        ISBN = 61804036
                    },
                    new Book
                    {
                        AuthorFN = "Stephen",
                        AuthorLN = "King",
                        Title = "Outsider",
                        Genre = "Horror",
                        Price = 31.50m,
                        Publisher = "Prószyński Media",
                        Pages = 544,
                        ReleaseDate = new DateTime(2018, 06, 05),
                        ISBN = 25981131
                    },
                    new Book
                    {
                        AuthorFN = "Graham",
                        AuthorLN = "Mastertron",
                        Title = "Infekcja",
                        Genre = "Horror",
                        Price = 28.72m,
                        Publisher = "Czarna Owca",
                        Pages = 332,
                        ReleaseDate = new DateTime(2019, 01, 22),
                        ISBN = 26365077
                    },

                     new Book
                    {
                        AuthorFN = "Georgia",
                        AuthorLN = "Cates",
                        Title = "Piękno oddania",
                        Genre = "Romans",
                        Price = 29.99m,
                        Publisher = "NieZwykłe",
                        Pages = 269,
                        ReleaseDate = new DateTime(2019, 04, 24),
                        ISBN = 31546294
                    },

                      new Book
                    {
                        AuthorFN = "Michelle",
                        AuthorLN = "Obama",
                        Title = "Becoming",
                        Genre = "Biografie",
                        Price = 37.49m,
                        Publisher = "Agora",
                        Pages = 170,
                        ReleaseDate = new DateTime(2019, 02, 13),
                        ISBN = 25671186
                    },

                       new Book
                    {
                        AuthorFN = "Rachel A.",
                        AuthorLN = "Marks",
                        Title = "Ogień i kość",
                        Genre = "Młodzieżowe",
                        Price = 25.99m,
                        Publisher = "Young",
                        Pages = 366,
                        ReleaseDate = new DateTime(2015, 08, 03),
                        ISBN = 17934015
                    }
                },
                
                discountCodes: new List<DiscountCode>
                {
                    new DiscountCode {Code = "Black Friday", Amount = 50},
                    new DiscountCode {Code = "Summer", Amount = 20},
                    new DiscountCode {Code = "Easter", Amount = 15},
   
                }
            );
        }
    }
}