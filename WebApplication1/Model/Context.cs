using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Model
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<WordPair> WordPairs { get; set; }
    }
}
