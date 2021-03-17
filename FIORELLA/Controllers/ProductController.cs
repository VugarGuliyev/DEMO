using FrontToBack.DAL;
using FrontToBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ProductCount = _context.Products.Count();
            return View(_context.Products.Include(x => x.Category).Take(4));
        }

        public IActionResult Load(int skip)
        {
            if (skip >= _context.Products.Count())
                return Content("ENOUGH!");

            IEnumerable<Product> model = _context.Products.Include(x => x.Category).Skip(skip).Take(4);

            return PartialView("_ProductPartial", model);
        }
    }
}
