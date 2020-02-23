using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class YearOfCarProductionintadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "YearOfCarProduction",
                table: "Vehicles",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearOfCarProduction",
                table: "Vehicles");
        }
    }
}
