namespace ScottBlog.Controllers
{
    public class BlogsController : Controllers
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