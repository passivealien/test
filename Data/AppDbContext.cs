using Microsoft.EntityFrameworkCore;
using SixMinApi.Model;

namespace SixMinApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Command> Commands => Set<Command>();
    }
}
