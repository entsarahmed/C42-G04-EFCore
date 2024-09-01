using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmployeeDepartmentView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"Create View EmployeeDepartmentView
                                  with Encryption, SchemaBinding
                                  As
                                 Select E.Id 'EmployeeCode', E.Name 'EmployeeName',D.Id 'DepartmentId', D.Name 'DepartmentName'
                                 from dbo.Employees E Left Outer Join dbo.Departments D 
                                   On E.DepartmentId = D.Id");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           // migrationBuilder.Sql(@"Drop View EmployeeDepartmentView");
        }
    }
}
