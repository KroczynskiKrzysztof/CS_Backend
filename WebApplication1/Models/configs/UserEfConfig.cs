using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.configs;

public class UserEfConfig: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(user => user.UserId).HasName("User_PK");

        builder.Property(user => user.Password).IsRequired().HasMaxLength(64);

        builder.Property(user => user.Username).IsRequired().HasMaxLength(64);

        builder.Property(user => user.DisplayName).IsRequired().HasMaxLength(64);

        builder.Property(user => user.PrefEng).IsRequired();
        
        builder
            .HasMany(u => u.Posts)
            .WithOne(post => post.Author)
            .HasForeignKey(post => post.UserId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("User_Post");

        builder
            .HasMany(u => u.Comments)
            .WithOne(comment => comment.User)
            .HasForeignKey(comment => comment.UserId)
            .OnDelete(DeleteBehavior.Cascade)
            .HasConstraintName("User_Comment");

        builder.ToTable("User");
    }
}