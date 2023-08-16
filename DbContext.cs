using Microsoft.EntityFrameworkCore;

namespace Blazor
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        { }

        public DbSet<ExecutedCommands> ExecutedCommands { get; set; }
        // Other DbSet properties for other tables...

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExecutedCommands>().HasKey(ec => ec.IdDeviceCommand);
            // For other entities...
        }
    }
}
