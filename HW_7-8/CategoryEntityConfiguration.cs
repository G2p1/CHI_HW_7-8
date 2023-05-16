using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.SqlServer;


namespace HW_7_8
{
    public class CategoryEntityConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.ExpensesCategory)
                .IsRequired()
                .HasMaxLength(255);

            builder.HasIndex(s => new { s.Id });

        }
    }
}
