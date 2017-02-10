using Microsoft.EntityFrameworkCore;

namespace GummiBearKingdom.Models
{
    public class GummiBearDBContext : DbContext
    {
        public GummiBearDBContext()
        {

        }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=GummiBearKingdom;integrated security=True");
        }

        public GummiBearDBContext(DbContextOptions<GummiBearDBContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}