using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class addAnnotationsinRentalVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Annotations",
                table: "RentalVehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Annotations",
                table: "RentalVehicles");
        }
    }
}
