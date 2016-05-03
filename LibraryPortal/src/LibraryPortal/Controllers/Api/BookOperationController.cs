using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using LibraryPortal.Models;

namespace LibraryPortal.Controllers.Api
{
    [Route("api/[controller]")]
    public class BookOperationController : Controller
    {
        private LibraryContext _context;

        public BookOperationController(LibraryContext context)
        {
            _context = context;
        }
        
        // POST: api/bookoperation/5
        [HttpPost("{id}")]
        public JsonResult PostBookOperation(int id, [FromBody] int status)
        {
            Book book = _context.Books.Single(m => m.Id == id);

            if (null != book)
            {
                book.Status = status;
                _context.SaveChanges();
            }

            return Json(book);
            
        }

        // DELETE: api/bookoperation/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Book book = _context.Books.Single(m => m.Id == id);
            if (book == null)
            {
                return HttpNotFound();
            }

            _context.Books.Remove(book);
            _context.SaveChanges();

            return Ok(book);
        }

    }
}
