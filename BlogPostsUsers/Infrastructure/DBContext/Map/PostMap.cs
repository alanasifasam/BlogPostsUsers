using BlogPostsUsers.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogPostsUsers.Infrastructure.DBContext.Map
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.id);
            builder.HasOne(x => x.User).WithMany(x => x.Posts).HasForeignKey(x => x.user_id);
            builder.Property(x => x.title);
            builder.Property(x => x.content_text);
            builder.Property(x => x.photo_url);
            builder.Property(x => x.created_at);
            builder.Property(x => x.updated_at);
            builder.Property(x => x.description);
            builder.Property(x => x.content_html);
            builder.Property(x => x.category);
        }
    
        
    }
}
