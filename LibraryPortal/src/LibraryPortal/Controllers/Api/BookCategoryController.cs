using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LibraryPortal.Models;

namespace LibraryPortal.Controllers.Api
{
    [Route("api/[controller]")]
    public class BookCategoryController : Controller
    {
        private LibraryContext _context;

        public BookCategoryController(LibraryContext context)
        {
            _context = context;
        }
        // GET: api/bookcategory
        [HttpGet]
        public IEnumerable<BookCategory> Get()
        {
            return _context.BookCategories.ToList();
        }
        
    }
}
