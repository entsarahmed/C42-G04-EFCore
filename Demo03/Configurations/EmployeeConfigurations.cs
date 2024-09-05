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
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.Property(E => E.Name)
                            .HasColumnType("varchar")
                            .HasMaxLength(50);
            //builder.Property(E => E.Age)
            //    .Range()

            builder.Property(E => E.Address)
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .HasDefaultValue("Cairo");
            builder.Property(E => E.Salary)
                .HasColumnType("decimal(12,2)");


        }
    }
}
