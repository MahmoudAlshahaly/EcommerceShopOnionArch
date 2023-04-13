using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SharedLayer.Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Infrastructure.ConFigration
{
    public class ProductConfig: IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(i => i.id);

            builder.Property(i => i.name)
                   .IsUnicode(true) //nvarchar not varchar
                   .IsRequired() //not null
                   .HasMaxLength(100);

            builder.Property(i => i.description)
                   .IsRequired();
            //.HasDefaultValue(5000);
        }
    }
}
