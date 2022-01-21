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

        //  GET
        public IActionResult Add()
        {
            return View();
        }

        //  POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Book obj)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
            
        }
    }
}
