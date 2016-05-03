using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LibraryPortal.Models;
using LibraryPortal.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryPortal.Controllers
{
    public class HomeController : Controller
    {
        private LibraryContext _context;

        public HomeController(LibraryContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CategoryViewModels models = new CategoryViewModels
            {
                Cats = new List<CategoryViewModel>()
            };

            var cats = _context.BookCategories.ToList();
            foreach(var c in cats)
            {
                var m = new CategoryViewModel();
                m.Id = c.Id;
                m.Name = c.Name;
                m.Count = _context.Books.Where(x => x.Type == c.Id).Count();
                m.ImgName = c.Id + ".jpg";

                

                (models.Cats as List<CategoryViewModel>).Add(m);
            }

            return View(models);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
