using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Route.Demo.DataAccess.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProfileImageNameToEmployeeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileImage",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileImage",
                table: "Employees");
        }
    }
}
