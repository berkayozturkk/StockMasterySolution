using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("STK").HasKey(b => b.ID);

        builder.Property(b => b.ID).HasColumnName("Id").IsRequired();
        builder.Property(b => b.ProductName).HasColumnName("MalKodu").IsRequired();
        builder.Property(b => b.ProductCode).HasColumnName("MalAdı").IsRequired();

        builder.HasIndex(x => x.ProductCode).IsClustered();
    }
}
