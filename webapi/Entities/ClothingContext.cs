using Microsoft.EntityFrameworkCore;

namespace webapi.Entities
{
    public class ClothingContext:DbContext
    {
        public ClothingContext(DbContextOptions<ClothingContext> options):base(options)
        {
            
        }
        public DbSet<Clothing> Clothings { get; set; }
    }
}
