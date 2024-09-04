using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo02.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneTotalParticipation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.AddColumn<int>(
                name: "DetailsAddress_BlockNo",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "DetailsAddress_City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailsAddress_Country",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DetailsAddress_Street",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreationDate",
                schema: "dbo",
                table: "Department",
                type: "date",
                nullable: false,
                computedColumnSql: "Cast(GetDate() as Date)",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldComputedColumnSql: "GetDate()");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailsAddress_BlockNo",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailsAddress_City",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailsAddress_Country",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DetailsAddress_Street",
                table: "Employees");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "CreationDate",
                schema: "dbo",
                table: "Department",
                type: "date",
                nullable: false,
                computedColumnSql: "GetDate()",
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldComputedColumnSql: "Cast(GetDate() as Date)");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentId",
                table: "Employees",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Department",
                principalColumn: "DeptId");
        }
    }
}
