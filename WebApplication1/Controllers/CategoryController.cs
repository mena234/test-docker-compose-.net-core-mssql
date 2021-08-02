using System.Linq;
using WebApplication1.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly Context _context;

        public CategoryController(Context context)
        {
            _context = context;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Categories.ToList());
        }
        [HttpPost]
        public IActionResult Post([FromBody] Category Category)
        {
            _context.Categories.Add(Category);
            _context.SaveChanges();
            return Ok();

        }
    }
}
