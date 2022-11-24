using Microsoft.EntityFrameworkCore;
using RedisP1.Models.v1;

namespace RedisP1.Database.v1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pix> Pixes { get; set; }
        public DbSet<CreditCard> CreditCards { get; set; }
        public DbSet<DebitCard> DebitCards { get; set; }
    }
}
