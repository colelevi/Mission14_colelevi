using Microsoft.EntityFrameworkCore;

namespace Mission14_API.Data
{
    public class MovieDbContext : DbContext 
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options) : base(options) { }

        public DbSet<MovieCollection> Movies { get; set; }
    }
}
