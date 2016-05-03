using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryPortal.ViewModels
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string ImgName { get; set; }
    }

    public class CategoryViewModels
    {
        public IEnumerable<CategoryViewModel> Cats { get; set; }
    }
}
