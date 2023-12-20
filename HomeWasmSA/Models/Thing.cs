using Microsoft.EntityFrameworkCore;

namespace HomeWasmSA.Models
{
    public class ThingContext : DbContext
    {
        public ThingContext(DbContextOptions<ThingContext> opts) : base(opts)
        {
        }

        public DbSet<Thing> Things { get; set; } = null!;
    }

    public class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
