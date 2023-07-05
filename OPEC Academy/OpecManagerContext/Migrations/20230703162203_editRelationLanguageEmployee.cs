using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OpecDataBase.DAL.Migrations
{
    /// <inheritdoc />
    public partial class editRelationLanguageEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_Lang_Id",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Lang_Id",
                table: "Employees",
                column: "Lang_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Employees_Lang_Id",
                table: "Employees");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_Lang_Id",
                table: "Employees",
                column: "Lang_Id",
                unique: true);
        }
    }
}
