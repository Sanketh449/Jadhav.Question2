using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Jadhav.Question2.Models
{
    public class Books
    {
        [Key]
        [Display(Name = "Books")]
        [Required(ErrorMessage = "BookId cannot be empty")]
            public int BookId { get; set; }

            [Required(ErrorMessage = "ISBN cannot be empty")]
            public string ISBN { get; set; }

            [Required(ErrorMessage = "Book Name cannot be empty")]
            [Display(Name = "Book Name")]
            public string BookName { get; set; }

            [Required(ErrorMessage = "Genre cannot be empty")]
            public string Genre { get; set; }

            [Required(ErrorMessage = "AuthorName cannot be empty")]
            public string AuthorName { get; set; }

           
            public DateTime PublishedDate { get; set; } 
            public DateTime AddedDate { get; set; } = DateTime.Now;

    }
}