using Jadhav.Question2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Jadhav.Question2.ViewModels
{
    public class BooksByAuthorNameVM
    {
        public IEnumerable<SelectListItem> AuthorName { get; set; }

        public IEnumerable<Books> Books { get; set; }
    }
}