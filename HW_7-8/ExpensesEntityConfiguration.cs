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
    public class ExpensesEntityConfiguration :IEntityTypeConfiguration<Expenses>
    {
         public void Configure(EntityTypeBuilder<Expenses> builder)
    {
        builder.HasKey(s => s.Id);

            builder.Property(s => s.CatId)
                    .IsRequired();

        builder.Property(s => s.Comment)
            .IsRequired()
            .HasMaxLength(255);

            builder.Property(s => s.DateOfMake)
                    .IsRequired();

        builder.HasIndex(s => new { s.Id });

    }
}
}
