using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;

namespace NLayer.Repository.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
           builder.HasKey(x => x.Id);// primary key
            builder.Property(x => x.Id).UseIdentityColumn();//auto increment
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(100);
            builder.ToTable("Category");//buraya isim vermezsek AppDbContext'de verdiğimiz isim ile kaydedilir

        }
    }
}
