﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayerApi.Core.Models;

namespace NLayerApi.Repository.Seeds;

internal class ProductSeed : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasData(
            new Product{ Id = 1, Name = "Kalem 1", CategoryId = 1, Price = 100, Stock = 20, CreatedDate = DateTime.Now},
            new Product { Id = 2, Name = "Kalem 2", CategoryId = 1, Price = 134, Stock = 12, CreatedDate = DateTime.Now },
            new Product { Id = 3, Name = "Kalem 3", CategoryId = 1, Price = 129, Stock = 566, CreatedDate = DateTime.Now },
            new Product { Id = 4, Name = "Kitap 1", CategoryId = 2, Price = 500, Stock = 544, CreatedDate = DateTime.Now },
            new Product { Id = 5, Name = "Kitap 2", CategoryId = 2, Price = 1234, Stock = 123, CreatedDate = DateTime.Now }
        );
    }
}   