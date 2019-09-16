using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GisBooks.Models
{
    public class BooksView
    {
        public int id { get; set; }

        [Display(Name = "Название произведения")]
        public string title { get; set; }

        [Display(Name = "Автор")]
        public string author { get; set; }

        [Display(Name = "Жанр")]
        public string genre { get; set; }

        [Display(Name = "Издательство")]
        public string publisher { get; set; }

        [Display(Name = "Первая публикация")]
        public string releaseYear { get; set; }
    }
}