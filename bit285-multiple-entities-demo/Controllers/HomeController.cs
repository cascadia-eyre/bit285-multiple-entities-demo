using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IndyBooks.Models;
using IndyBooks.ViewModels;

namespace IndyBooks.Controllers
{
    public class HomeController : Controller
    {
        BookstoreDbContext db = new BookstoreDbContext();

        /*
         * Purchase Creation and List
         */
        public ActionResult Purchase()
        {
            var pvm = new PurchaseViewModel();  // creates a new viewmodel object and
            pvm.Books = db.Books;               // assigns values to viewmodel collections
            pvm.Members = db.Members;

            return View(pvm);
        }
        [HttpPost]
        public ActionResult Purchase(Purchase purchase)
        {
            if(ModelState.IsValid)
            {
                db.Purchases.Add(purchase);
                db.SaveChanges();
                return View("Purchases", db.Purchases);
            }
            return View();
        }
        /*
         * Book Creation and List
         */
        public ActionResult Books()
        {
            return View("Books", db.Books);
        }
        public ActionResult AddBook()
        {
            //TODO: Create a new ViewModel object, assign values to its collections, and pass it to the View

            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                db.Books.Add(book);
                db.SaveChanges();
                return View("Books", db.Books);
            }
<<<<<<< HEAD
            return View();
        }
        /*
          * Author Creation and List
          */
        public ActionResult AddAuthors() {

            return View();
        }
        [HttpPost]
        public ActionResult AddAuthors(Author author) {
            if (ModelState.IsValid)
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return View("Authors", db.Authors);
            }
            return View();
        }

        public ActionResult Authors()
        {
            return View("Authors", db.Authors);
        }
        /*
          * Member Creation and List 
          */
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(Member member)
        {
            if (ModelState.IsValid)
            {
                db.Members.Add(member);
                db.SaveChanges();
                return View("Members", db.Members);
            }
            return View();
        }

        public ActionResult Members()
        {
            return View("Members", db.Members);
        }
=======
            //TODO: Update your Book Listing  View to display the Authors Full Name, rather than the AuthorID
            return View();
        }

>>>>>>> 403ee8a12ee4d55e8f43e6c688eefe878253295a
    }
}