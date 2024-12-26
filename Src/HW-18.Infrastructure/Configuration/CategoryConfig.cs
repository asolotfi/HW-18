using HW_18.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HW_18.Infrastructure.Configuration
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.ToTable("Categories");
            builder.Property(c => c.Name)
                  .IsRequired()
                  .HasMaxLength(50);

            builder.HasData(new Category
            {
                Id = 1,
                Name = "Electronica"

            });
            builder.HasData(new Category
            {
                Id = 2,
                Name = "Phone"

            });

        }
    }
}
