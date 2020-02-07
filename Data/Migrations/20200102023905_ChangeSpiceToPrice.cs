using Microsoft.EntityFrameworkCore.Migrations;

namespace Spice.Data.Migrations
{
    public partial class ChangeSpiceToPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spice",
                table: "MenuItem");

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "MenuItem",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "MenuItem");

            migrationBuilder.AddColumn<double>(
                name: "Spice",
                table: "MenuItem",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
