using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Models.configs;

public class RoleEfConfig: IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.HasKey(role => role.Id).HasName("role_pk");
        builder.Property(role => role.Name).IsRequired().HasMaxLength(32);

        builder.HasMany(role => role.Users)
            .WithOne(user => user.Role)
            .HasForeignKey(user => user.Roleid)
            .OnDelete(DeleteBehavior.Restrict)
            .HasConstraintName("user_role");
    }
}