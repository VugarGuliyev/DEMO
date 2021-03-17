using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToBack.DAL;
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Slides = _context.Slides,
                PageSign = _context.PageSign.FirstOrDefault(),

                Categories = _context.Categories,
                Products = _context.Products,
                About = _context.About.Include(x => x.AboutItems).FirstOrDefault(),
                Experts = _context.Experts,
                Blogs = _context.Blogs,
                Quotes = _context.Quotes,
                Instagrams = _context.Instagrams
            };

            return View(homeVM);
        } 
    }
}
