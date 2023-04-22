using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloWorld.Data
{
	public class HelloWorldContext : DbContext
    {
        public HelloWorldContext (DbContextOptions<HelloWorldContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } = default!;
    }
}
 