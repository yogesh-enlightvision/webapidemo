using Microsoft.EntityFrameworkCore;
using MyCleanAPI.Domain.Entities;

namespace MyCleanAPI.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}