using BlogPostsUsers.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogPostsUsers.Infrastructure.DBContext.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder ) 
        {
            builder.HasKey(x => x.id );
            builder.Property(x => x.last_name);
            builder.Property(x => x.email);
            builder.Property(x => x.phone);
            builder.Property(x => x.street);
            builder.Property(x => x.state);
            builder.Property(x => x.zipcode);
            builder.Property(x => x.latitude);
            builder.Property(x => x.gender);
            builder.Property(x => x.first_name);
            builder.Property(x => x.date_of_birth);
            builder.Property(x => x.job);
            builder.Property(x => x.city);
            builder.Property(x => x.country);
            builder.Property(x => x.longitude);

        }
    }
}
