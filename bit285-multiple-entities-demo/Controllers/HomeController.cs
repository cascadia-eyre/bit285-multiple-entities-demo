﻿using System;
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
        public ActionResult AddBook()
        {
            
            var abvm = new AddBookViewModel();
            abvm.Authors = db.Authors;
            return View(abvm);
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
            //TODO: Update your Book Listing  View to display the Authors Full Name, rather than the AuthorID
            return View();
        }

    }
}