using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaseID { get; set; }
        public decimal Amount { get; set; } // The purchase price of the book
        public int BookID { get; set; }     // The book purchased
<<<<<<< HEAD
        public int MemberID { get; set; } //The member who purchased the book
=======
        public int MemberID { get; set; }   // The customer

        public virtual Book Book { get; set; } //A 

>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
    }
}