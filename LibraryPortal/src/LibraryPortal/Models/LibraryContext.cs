using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;

namespace LibraryPortal.Models
{
    public class LibraryContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connString = Startup.Configuration["Data:EFConnection:ConnectionString"];
            optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }


    }
}
