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
                    AuthorID = 1,
                    Price = 9.99M
                },
                new Book()
                {
                    BookID = 2,
                    Title = "Northanger Abbey",
                    AuthorID = 1,
                    Price = 12.95M
                },
                new Book()
                {
                    BookID = 3,
                    Title = "David Copperfield",
                    AuthorID = 2,
                    Price = 15.00M
                },
                new Book()
                {
                    BookID = 4,
                    Title = "The Wizard of EarthSea",
                    AuthorID = 3,
                    Price = 8.95M
                },
                new Book()
                {
                    BookID = 5,
                    Title = "The Tombs of Atuan",
                    AuthorID = 3,
                    Price = 7.95M
                },
                new Book()
                {
                    BookID = 6,
                    Title = "The Farthest Shore",
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
                },
                new Author()
                {
                    AuthorID = 3,
                    FirstName = "Ursula",
                    LastName = "Le Guin"
                });
            //Members
            context.Members.AddOrUpdate(m => m.MemberID,
                new Member()
                {
                    MemberID = 1,
                    FirstName = "Ian",
                    LastName = "Bansenauer"
                },
                new Member()
                {
                    MemberID = 2,
                    FirstName = "Brian",
                    LastName = "Bansenauer"
                },
                new Member()
                {
                    MemberID = 3,
                    FirstName = "Mark",
                    LastName = "Von Cackles"
                },
                new Member()
                {
                    MemberID = 4,
                    FirstName = "Samithy",
                    LastName = "Callen"
                },
                new Member()
                {
                    MemberID = 5,
                    FirstName = "Brigette",
                    LastName = "Jerome"
                }
                );
            // few more Purchase records
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
                    Amount = 15.00M,
                    BookID = 3,
                    MemberID = 1
                },
                new Purchase()
                {
                    PurchaseID = 3,
                    Amount = 10.00M,
                    BookID = 4,
                    MemberID = 2
                },
                new Purchase()
                {
                    PurchaseID = 4,
                    Amount = 8.00M,
                    BookID = 5,
                    MemberID = 2
                },
                new Purchase()
                {
                    PurchaseID = 5,
                    Amount = 10.00M,
                    BookID = 2,
                    MemberID = 4
                }
                );

        }
    }
}
