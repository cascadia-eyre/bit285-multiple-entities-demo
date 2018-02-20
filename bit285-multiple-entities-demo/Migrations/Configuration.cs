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
            AutomaticMigrationsEnabled = true;
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
                    Author = "Jane Austin",
                    Price = 9.99M,
                    AuthorID = 3
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    Author = "Jane Austin",
                    Price = 12.95M,
                    AuthorID = 3
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    Author = "Charles Dickens",
                    Price = 15.00M,
                    AuthorID = 4
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    Author = "Ursula Le Guin",
                    Price = 8.95M,
                    AuthorID = 5
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    Author = "Ursula Le Guin",
                    Price = 7.95M,
                    AuthorID = 5
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
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
                },
                new Author()
                {
                    AuthorID = 3,
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

         
            context.Purchases.AddOrUpdate(p => p.PurchaseID,
                new Purchase()
                {
                    PurchaseID = 1,
                    Amount = 10.00M,
                    BookID = 6,
                    MemberID = 1
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
                });

        }
    }
}
