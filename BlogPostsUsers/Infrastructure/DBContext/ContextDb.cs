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
        public DbSet<StatusUser> StatusUsers { get; set; }
        public DbSet<StatusPost> StatusPosts { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.ApplyConfiguration( new UserMap());
            modelBuilder.ApplyConfiguration( new PostMap());
        }

    }
}
