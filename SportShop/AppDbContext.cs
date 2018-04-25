using Microsoft.EntityFrameworkCore;

namespace SportShop
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Customers> Customers {get; set;}
    }
}