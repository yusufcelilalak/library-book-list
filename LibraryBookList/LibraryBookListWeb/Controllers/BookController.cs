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

        //  GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var bookFromDb = _db.Books.Find(id);

            if(bookFromDb == null)
            {
                return NotFound();
            }

            return View(bookFromDb);
        }

        //  POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Book obj)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);

        }

        // GET and REMOVE THE DATA FROM TABLE
        public IActionResult Delete(int? id)
        {

            var bookObj = _db.Books.Find(id);

            if( bookObj == null)
            {
                return NotFound();
            }

            _db.Books.Remove(bookObj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
