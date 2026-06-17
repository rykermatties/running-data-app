using Microsoft.EntityFrameworkCore;
using RunningData.Models;

namespace RunningData.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Run> Runs { get; set; }
    }
}