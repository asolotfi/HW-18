using HW_18.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HW_18.Infrastructure.Configuration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("Users");
            builder.Property(c => c.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(c => c.Password)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.HasData(new User
            {
                Id = 1,
                UserName = "Aso",
                Password = "1234"

            });
        }
    }
}
