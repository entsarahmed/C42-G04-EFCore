using Demo.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Configurations
{
    internal class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Fluent APIS For Employee Model 

            builder.Property("Address")/*ShadowProperty : notTypeSafe*/ // nameof(Employee.Address) || E => E.Address [ Recommended ]
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired(true)
                    .HasDefaultValue("Cairo");


            builder.HasOne(E => E.Department)
            .WithMany(D => D.Employees)
            .HasForeignKey(E => E.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade);




        }
    }
}
