using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item>
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("STI").HasKey(b => b.ID);

        builder.Property(b => b.ID).HasColumnName("Id").IsRequired();
        builder.Property(b => b.TransactionType).HasColumnName("IslemTur").IsRequired();
        builder.Property(b => b.DocumentNo).HasColumnName("EvrakNo").IsRequired();
        builder.Property(b => b.Date).HasColumnName("Tarih").IsRequired();
        builder.Property(b => b.ProductCode).HasColumnName("MalKodu").IsRequired();
        builder.Property(b => b.Amount).HasColumnName("Miktar").IsRequired();
        builder.Property(b => b.Price).HasColumnName("Fiyat").IsRequired();
        builder.Property(b => b.Salary).HasColumnName("Tutar").IsRequired();
        builder.Property(b => b.Unit).HasColumnName("Birim").IsRequired();

        builder.HasIndex(x => x.DocumentNo).IsClustered();
        builder.HasIndex(x => x.Date).IsClustered();
        builder.HasIndex(x => x.TransactionType).IsClustered();
    }
}
