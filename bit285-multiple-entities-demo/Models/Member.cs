using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IndyBooks.Models
{
    public class Member
    {
        [Key]
        public int MemberID { get; set; }
<<<<<<< HEAD
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Birthyear { get; set; }
        
        public virtual ICollection<Purchase> MemberPurchases { get; set; }
=======

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get { return FirstName + " " + LastName; } }
        // Property to represent the entity relationship: "A Member can have many Purchases"
        public ICollection<Purchase> Purchases { get; set; }
>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
    }
}