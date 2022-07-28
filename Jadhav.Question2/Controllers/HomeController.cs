using Jadhav.Question2.Models;
using Jadhav.Question2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Jadhav.Question2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext = null;

        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }

        private IEnumerable<SelectListItem> PopulateAuthorName()
        {
            return _dbContext.Books.Select(c => new SelectListItem
            {
                Value = c.AuthorName,
                Text = c.AuthorName,
            }).AsEnumerable();
        }

        public ActionResult Index()
        {
            BooksByAuthorNameVM booksByAuthorName = new BooksByAuthorNameVM();
            var authorName = PopulateAuthorName();
            booksByAuthorName.AuthorName = authorName;
            return View(booksByAuthorName);
        }

        //[HttpGet]        
        public ActionResult GetBooks(string AuthorName)
        {
            BooksByAuthorNameVM booksByAuthorName = new BooksByAuthorNameVM();
            var books = _dbContext.Books.Where(p => p.AuthorName == AuthorName); 
            booksByAuthorName.Books = books;

            var authorName = PopulateAuthorName();
            booksByAuthorName.AuthorName = authorName;
            return View("Index",booksByAuthorName);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}