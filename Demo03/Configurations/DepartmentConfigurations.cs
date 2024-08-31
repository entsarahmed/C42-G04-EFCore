using Demo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id)
                .UseIdentityColumn(10,10);

            builder.Property(D => D.Name)
                            .HasColumnType("varchar")
                            .HasMaxLength(50);
            builder.Property(D => D.CreationDate)
            //    //.HasDefaultValue("GETDATE()")
                .HasComputedColumnSql("GETDATE()");


        }
    }
}
