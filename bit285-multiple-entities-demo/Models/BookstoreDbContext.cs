using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class BookstoreDbContext : DbContext
    {
     //Constructor - gives the name of the database
        public BookstoreDbContext() : base("IndyBooksViewModelDB") { }

     // Entity representing all the books
        public DbSet<Book> Books { get; set; }

      // Entity representing store members
        public DbSet<Member> Members { get; set; }

     // Entity representing purchases
        public DbSet<Purchase> Purchases { get; set; }

<<<<<<< HEAD
     //Entity representing authors
       public DbSet<Author> Authors { get; set; }


=======
     // Entity representing author
        public DbSet<Author> Authors { get; set; }
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a

    }
}