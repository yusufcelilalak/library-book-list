using LibraryBookListWeb.Data;
using LibraryBookListWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryBookListWeb.Controllers
{
    public class BookController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Book> objToBook = _db.Books;
            return View(objToBook);
        }
    }
}
