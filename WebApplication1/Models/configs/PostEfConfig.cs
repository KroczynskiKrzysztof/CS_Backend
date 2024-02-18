using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.configs;

public class PostEfConfig: IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder.HasKey(post => post.PostId).HasName("Post_PK");

        builder.Property(post => post.UserId).IsRequired();

        builder.Property(post => post.Title).IsRequired().HasMaxLength(32);

        builder.Property(post => post.Content).IsRequired().HasMaxLength(512);

        builder.Property(post => post.DateTime).IsRequired().HasDefaultValueSql("DATE('now')");

        builder.HasMany(post => post.Comments)
            .WithOne(comment => comment.Post)
            .HasForeignKey(comment => comment.PostId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Property(post => post.State).IsRequired().HasDefaultValue(0);
    }
}