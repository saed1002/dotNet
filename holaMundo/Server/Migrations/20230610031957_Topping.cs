using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace holaMundo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Topping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Toppings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Toppings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Toppings");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Toppings");
        }
    }
}
