using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LibraryPortal.ViewModels;
using LibraryPortal.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryPortal.Controllers
{
    public class BookController : Controller
    {
        private LibraryContext _context;

        public BookController(LibraryContext context)
        {
            _context = context;
        }
        // GET: /book/1        
        public IActionResult Index(int id)
        {
            ViewData["type"] = id;
            return View();
        }

        public IActionResult Create()
        {
            ViewData["BookCats"] = LibraryPortal.Utility.ADOOperationcs.GetBookCategories();
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookViewModel model)
        {
            if (ModelState.IsValid)
            {
                var book = new Book()
                {
                    Name = model.Name,
                    Pages = model.Pages,
                    Author = model.Author,
                    Type = model.Type,
                    Year = model.Year,
                    Status = 1
                };

                _context.Books.Add(book);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
