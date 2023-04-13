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
    public class CategoryConfig: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(i => i.id);

            builder.Property(i => i.name)
                   .IsUnicode(true) 
                   .IsRequired() //not null
                   .HasMaxLength(50);

            builder.Property(i => i.description)
                
                   .IsRequired();
            
        }
    }
}
