using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.Models;

namespace FrontToBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slide> Slides { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public PageSign PageSign { get; set; }
        public About About { get; set; }

        public IEnumerable<Expert> Experts { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Quote> Quotes { get; set; }
        public IEnumerable<Instagram> Instagrams { get; set; }
    }
}
