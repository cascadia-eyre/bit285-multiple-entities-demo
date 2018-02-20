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
        
        public string Name { get; set; }
        public string FirstBook { get; set; }
        public int Birthyear { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}