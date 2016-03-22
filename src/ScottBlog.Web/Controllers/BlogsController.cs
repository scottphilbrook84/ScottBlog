using Microsoft.AspNet.Mvc;
using ScottModel.Models;
using System.Linq;

namespace ScottBlog.Controllers
{
    public class BlogsController : Controller
    {
        private BloggingDbContext _context;
        
        public BlogsController(BloggingDbContext context)
        {
            _context = context;
            
        }

        public IActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }

        public IActionResult Create()
        {
            return View();
            
        }
        
       
        
    }
}