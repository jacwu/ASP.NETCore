using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryPortal.Models
{
    public class DatabaseSeed
    {
        private LibraryContext _context;

        public DatabaseSeed(LibraryContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if (!_context.BookCategories.Any())
            {
                _context.BookCategories.Add(new BookCategory() { Name = "Engineering" });
                _context.BookCategories.Add(new BookCategory() { Name = "Medicine" });
                _context.BookCategories.Add(new BookCategory() { Name = "Architecture" });
                _context.BookCategories.Add(new BookCategory() { Name = "Law" });
                _context.BookCategories.Add(new BookCategory() { Name = "Finance" });
                _context.BookCategories.Add(new BookCategory() { Name = "Novel" });

                _context.SaveChanges();
            }

            if (!_context.Books.Any())
            {
                _context.Books.Add(new Book()
                {
                    Name = "Medicine book 1",
                    Year = 1980,
                    Pages = 1250,
                    Author = "James",
                    Type = 2,
                    Status = 1
                });

                _context.Books.Add(new Book()
                {
                    Name = "Medicine book 2",
                    Year = 1970,
                    Pages = 120,
                    Author = "Jenny",
                    Type = 2,
                    Status = 1
                });

                _context.Books.Add(new Book()
                {
                    Name = "Surgical",
                    Year = 1991,
                    Pages = 1190,
                    Author = "Jacky",
                    Type = 2,
                    Status = 1
                });

                _context.Books.Add(new Book()
                {
                    Name = "Heart Disease",
                    Year = 1967,
                    Pages = 390,
                    Author = "Richard",
                    Type = 2,
                    Status = 1
                });

                _context.Books.Add(new Book()
                {
                    Name = "Eye Disease",
                    Year = 2010,
                    Pages = 290,
                    Author = "Rita",
                    Type = 2,
                    Status = 1
                });


                _context.SaveChanges();
            }
        }
    }
}
