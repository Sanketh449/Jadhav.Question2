using Jadhav.Question2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Jadhav.Question2.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public BookController()
        {
            _dbContext = new ApplicationDbContext();
        }


        public ActionResult Index()
        {
            var books = _dbContext.Books.ToList();
            return View(books);//return list of product
        }

        //GET
        public ActionResult Details(int BookId)
        {
            var books = _dbContext.Books.FirstOrDefault(p => p.BookId == BookId);
            if (books != null)
            {
                return View(books);
            }
            return HttpNotFound();
        }
        [HttpGet]
        public ActionResult Create()
        {
            var authorName = _dbContext.Books.ToList();
            ViewBag.authorName = authorName;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(Books books)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Books.Add(books);
                _dbContext.SaveChanges();//To reflect the changes to database
                return RedirectToAction("Index");
            }
            var authorName = _dbContext.Books.ToList();
            ViewBag.authorName = authorName;
            return View();

        }
        
    }
}