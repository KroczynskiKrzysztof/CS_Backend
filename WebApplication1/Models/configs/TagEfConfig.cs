using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.configs;

public class TagEfConfig: IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.HasKey(tag => tag.TagId).HasName("Tag_PK");

        builder.Property(tag => tag.Name).IsRequired().HasMaxLength(32);
    }
}