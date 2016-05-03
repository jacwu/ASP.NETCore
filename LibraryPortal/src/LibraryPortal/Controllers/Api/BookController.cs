using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LibraryPortal.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryPortal.Controllers.Api
{
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private LibraryContext _context;

        public BookController(LibraryContext context)
        {
            _context = context;
        }

        // GET: api/book
        public JsonResult Get()
        {
            return Json(_context.Books.ToList());
        }

        // GET: api/book/2
        [HttpGet("{type}")]
        public JsonResult Get(int type)
        {
            return Json(_context.Books.Where(m => m.Type == type).ToList());
        }

        // GET: api/book/2/1
        [HttpGet("{type}/{id}")]
        public IActionResult Get(int type, int id)
        {
            Book book = _context.Books.Single(m => m.Id == id);

            if (book == null)
            {
                return HttpNotFound();
            }

            return Ok(book);
        }


    }
}
