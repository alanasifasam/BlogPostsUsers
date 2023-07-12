using BlogPostsUsers.Domain.Model;
using BlogPostsUsers.Infrastructure.DBContext.Map;
using Microsoft.EntityFrameworkCore;

namespace BlogPostsUsers.Infrastructure.DBContext
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> opcoes) : base(opcoes) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().Property(x => x.id).ValueGeneratedNever();
            modelBuilder.ApplyConfiguration( new UserMap());
            modelBuilder.ApplyConfiguration( new PostMap());
        }

    }
}
