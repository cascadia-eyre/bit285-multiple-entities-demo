using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
<<<<<<< HEAD
        
        public string Name { get; set; }
        public string FirstBook { get; set; }
        public int Birthyear { get; set; }
        public virtual ICollection<Book> Books { get; set; }
=======

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }
        // Property to represent the entity relationship: "An Author can write many Books"
        public ICollection<Book> Books { get; set; }
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
    }
}