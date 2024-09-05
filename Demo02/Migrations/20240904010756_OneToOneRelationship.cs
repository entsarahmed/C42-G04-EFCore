using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo02.Migrations
{
    /// <inheritdoc />
    public partial class OneToOneRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManagerId",
                schema: "dbo",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_ManagerId",
                schema: "dbo",
                table: "Department",
                column: "ManagerId",
                unique: true,
                filter: "[ManagerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "dbo",
                table: "Department",
                column: "ManagerId",
                principalTable: "Employees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Employees_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_ManagerId",
                schema: "dbo",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "ManagerId",
                schema: "dbo",
                table: "Department");
        }
    }
}
