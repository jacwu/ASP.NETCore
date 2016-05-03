using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryPortal.ViewModels
{
    public class BookViewModel
    {
        [Required]
        [StringLength(50, ErrorMessage = "The {0} characters length should be between {2} and {1}.", MinimumLength = 1)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public int Pages { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} characters length should be between {2} and {1}", MinimumLength = 1)]
        public string Author { get; set; }

        [Required]
        public int Type { get; set; }
    }
}
