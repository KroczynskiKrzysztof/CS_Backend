using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.configs;

public class PostTagEfConfig: IEntityTypeConfiguration<PostTag>
{
    public void Configure(EntityTypeBuilder<PostTag> builder)
    {
        builder.HasKey(tag => new { tag.PostID, tag.TagID }).HasName("PostTag_PK");

        builder.HasOne(e => e.Post)
            .WithMany(post => post.PostTags)
            .HasForeignKey(tag => tag.PostID)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("PostTag_Post");
            
        builder
            .HasOne(e => e.Tag)
            .WithMany(tag => tag.PostTags)
            .HasForeignKey(tag => tag.TagID)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("PostTag_Tag");
    }
}