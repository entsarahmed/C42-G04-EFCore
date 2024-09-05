using Demo03.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Demo03.Data.Migrations
{
    internal class EmployeesDepartmentsViewConfigurations : IEntityTypeConfiguration<EmployeeDepartments>
    {
        public void Configure(EntityTypeBuilder<EmployeeDepartments> builder)
        {
            builder.ToView("EmployeeDepartmentsView").HasNoKey();
        }
    }
}
