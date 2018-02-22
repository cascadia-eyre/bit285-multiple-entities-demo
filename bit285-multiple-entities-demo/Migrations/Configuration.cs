namespace bit285_multiple_entities_demo.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using IndyBooks.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<IndyBooks.Models.BookstoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "IndyBooks.Models.BookstoreDbContext";
        }

        protected override void Seed(IndyBooks.Models.BookstoreDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            context.Books.AddOrUpdate(b => b.BookID,
                new Book()
                {
                    BookID = 1,
                    Title = "Pride and Prejudice",
<<<<<<< HEAD
                    Author = "Jane Austin",
                    Price = 9.99M,
                    AuthorID = 3
=======
                    AuthorID = 1,
                    Price = 9.99M
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
<<<<<<< HEAD
                    Author = "Jane Austin",
                    Price = 12.95M,
                    AuthorID = 3
=======
                    AuthorID = 1,
                    Price = 12.95M
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
<<<<<<< HEAD
                    Author = "Charles Dickens",
                    Price = 15.00M,
                    AuthorID = 4
=======
                    AuthorID = 2,
                    Price = 15.00M
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
<<<<<<< HEAD
                    Author = "Ursula Le Guin",
                    Price = 8.95M,
                    AuthorID = 5
=======
                    AuthorID = 3,
                    Price = 8.95M
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
<<<<<<< HEAD
                    Author = "Ursula Le Guin",
                    Price = 7.95M,
                    AuthorID = 5
=======
                    AuthorID = 3,
                    Price = 7.95M
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
<<<<<<< HEAD
                    Author = "Ursula Le Guin",
                    Price = 9.95M,
                    AuthorID = 5

                });
            context.Authors.AddOrUpdate(p => p.AuthorID, 
                new Author()
                {
                   AuthorID = 1,
                   Name = "Karl Marx",
                   FirstBook = "Communist Manifesto",
                   Birthyear = 1818
                },
                new Author()
                {
                    AuthorID = 2,
                    Name = "John Green",
                    FirstBook = "Looking for Alaska",
                    Birthyear = 1977
=======
                    AuthorID = 3,
                    Price = 9.95M

                });
            // Added several Author records
            context.Authors.AddOrUpdate(a => a.AuthorID,
                new Author()
                {
                    AuthorID = 1,
                    FirstName = "Jane",
                    LastName = "Austen"
                }, 
                new Author()
                {
                    AuthorID = 2,
                    FirstName = "Charles",
                    LastName = "Dickens"
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
                },
                new Author()
                {
                    AuthorID = 3,
<<<<<<< HEAD
                    Name = "Jane Austen",
                    FirstBook = "Sense and Sensibility",
                    Birthyear = 1775
                },
                new Author()
                {
                    AuthorID = 4,
                    Name = "Charles Dickens",
                    FirstBook = "The Pickwick Papers",
                    Birthyear = 1870
                },
                new Author()
                {
                    AuthorID = 5,
                    Name = "Ursula Le Guin",
                    FirstBook = "Untitled",
                    Birthyear = 1900
                }
                );

            context.Members.AddOrUpdate(p => p.MemberID,
                new Member()
                {
                    MemberID = 1, 
                    FirstName = "Kinzey",
                    LastName = "Huxton",
                    Birthyear = 2000
                },
                new Member()
                {
                    MemberID = 2,
                    FirstName = "Kyle",
                    LastName = "Hung",
                    Birthyear = 1998
                }
                );

         
=======
                    FirstName = "Ursula",
                    LastName = "Le Guin"
                });
            //TODO: Seed a few more Member records
            context.Members.AddOrUpdate(m => m.MemberID,
                new Member()
                {
                    MemberID = 1,
                    FirstName = "Ian",
                    LastName = "Bansenauer"
                });
            //TODO: Seed a few more Purchase records
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new Purchase()
                {
                    PurchaseID = 1,
                    Amount = 10.00M,
                    BookID = 6,
                    MemberID = 1
<<<<<<< HEAD
                },
                new Purchase()
                {
                    PurchaseID = 2,
                    Amount = 10.00M,
                    BookID = 4,
                    MemberID = 1
                },
                new Purchase()
                {
                    PurchaseID = 3,
                    Amount = 20.00M,
                    BookID = 6,
                    MemberID = 2
=======
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
                });

        }
    }
}
