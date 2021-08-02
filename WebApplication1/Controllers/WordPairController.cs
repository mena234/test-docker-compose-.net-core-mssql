using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordPairController : ControllerBase
    {
        private readonly Context _context;

        public WordPairController(Context context)
        {
            _context = context;
        }
        // GET: api/<CategoryController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.WordPairs.ToList());
        }
        [HttpPost]
        public IActionResult Post([FromBody] WordPair WordPair)
        {
            _context.WordPairs.Add(WordPair);
            _context.SaveChanges();
            return Ok();

        }
    }
}
