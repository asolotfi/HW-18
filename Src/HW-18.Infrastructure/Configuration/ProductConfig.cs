using HW_18.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace HW_18.Infrastructure.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
            // تنظیم رابطه به دسته
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Cascade); // رفتار حذف
            builder.ToTable("Products");
            builder.Property(c => c.Name)
                  .IsRequired()
                  .HasMaxLength(50);
            builder.Property(c => c.Price)
                  .IsRequired();
            builder.HasData(new Product
            {
                Id = 1,
                Name = "Phone",
                Price = 2000000,
                CategoryId = 2,
            });
            builder.HasData(new Product
            {
                Id = 2,
                Name = "Laptop",
                Price = 22000000,
                CategoryId = 1,
            });

        }
    }
}
