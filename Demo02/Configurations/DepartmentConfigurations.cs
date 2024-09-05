using Demo.Context;
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
    internal class DepartmentConfigurations : IEntityTypeConfiguration<Department>
    {
       
       

        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Fluent Apis For Department Model 
           

            builder.ToTable("Department", "dbo");
            builder.HasKey(D => D.DeptId);// Recommended //P.K
            ///modelBuilder.Entity<Department>().HasKey("DeptId");//P.k
            ///modelBuilder.Entity<Department>().HasKey(nameof(Department.DeptId));//P.K

            builder.Property(D => D.DeptId)
                    .UseIdentityColumn(10, 10);

            builder.Property(D => D.Name)
                .HasColumnName("DepartmentName")
                .HasColumnType(SQLDataTypes.Varchar)
                .HasMaxLength(50);
            ///.HasAnnotation("MaxLength", 50)
            ///.HasAnnotation("", );
            ///.HasAnnotation("", );
            ///.HasAnnotation("", );

            builder.Property(D => D.CreationDate)
                        .HasComputedColumnSql("Cast(GetDate() as Date)"); //When Mapping the Value Of the Column Will Take the Date of TableCreation [From Executing GetDate() SQL Method]


            //.HasDefaultValue(DateOnly.FromDateTime(DateTime.Now));//  static Date , When  Creating Table it take the Date Of [Add Migration ] 





            builder.HasMany(D => D.Employees)
               .WithOne(E => E.Department)
               .HasForeignKey(E => E.DepartmentId)
               .IsRequired(false)
               .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
