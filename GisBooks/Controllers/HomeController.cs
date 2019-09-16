using Dapper;
using GisBooks.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GisBooks.Controllers
{
    public class HomeController : Controller
    {
        readonly string constr = ConfigurationManager.ConnectionStrings["db"].ConnectionString;

        public ActionResult Index()
        {
            ViewBag.Title = "Книжечки";

            var books = new List<BooksView>();

            using (IDbConnection db = new SqlConnection(constr))
            {
                books = db.Query<BooksView>("SELECT dbo.books.title, dbo.authors.Author, dbo.genres.genre, dbo.publishers.Publisher, dbo.books.releaseYear " + 
                                            "FROM dbo.books INNER JOIN " +
                                                 "dbo.authors ON dbo.books.authorId = dbo.authors.id INNER JOIN " +
                                                 "dbo.genres ON dbo.books.genreId = dbo.genres.id INNER JOIN " +
                                                 "dbo.publishers ON dbo.books.publisherId = dbo.publishers.id").ToList();
            }

            return View(books);
        }

        
    }
}