using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new Product
            {
                Id = 1,
                CategoryId = 1,
                Name = "Kurşun kalem"
                ,Stock=2000,Price=100000
                ,CreatedDate = DateTime.Now,
            },
           new Product
           {
               Id = 2,
               CategoryId = 1,
               Name = "Tükenmez kalem"
                ,
               Stock = 2000,
               Price = 100000
                ,
               CreatedDate = DateTime.Now,
           }, new Product
           {
               Id = 3,
               CategoryId = 2,
               Name = "Kapaklı kitap"
                ,
               Stock = 2000,
               Price = 100000
                ,
               CreatedDate = DateTime.Now,
           });
        }
    }
}
