using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ScottBlog.Controllers
{
    public class HomeController : Controller
    {
        
       private BloggingDbContext _context;
        
        public HomeController(BloggingDbContext context)
        {
            _context = context;
            
        }
        
        public IActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Scott's Blog. Maybe.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
