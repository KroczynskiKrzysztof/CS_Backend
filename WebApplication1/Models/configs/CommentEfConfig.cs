using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.configs;

public class CommentEfConfig: IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.HasKey(comment => comment.CommentId).HasName("Comment_PK");

        builder.Property(comment => comment.UserId).IsRequired();
        builder.Property(comment => comment.PostId).IsRequired();
        builder.Property(comment => comment.Content).IsRequired().HasMaxLength(512);
        builder.Property(comment => comment.DateTime).IsRequired();
        
    }
}