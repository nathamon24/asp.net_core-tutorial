using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace test_migration.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext() { }
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("DataSource=app.db");
        }

        public DbSet<Blog> Blog { get; set; } = null!;
    }
}