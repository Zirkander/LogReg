using Microsoft.EntityFrameworkCore;

namespace LogReg.Models
{
    public class LogRegContext : DbContext
    {
        public LogRegContext(DbContextOptions options) : base(options) { }

        // public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
    }
}