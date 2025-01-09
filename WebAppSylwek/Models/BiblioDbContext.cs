
using Microsoft.EntityFrameworkCore;
namespace WebAppSylwek.Models
{
    public class BiblioDbContext : DbContext
    {       public BiblioDbContext(DbContextOptions<BiblioDbContext> options) : base(options)
        {
        }
        public DbSet<Item> Items { get; set; }
    }
}