using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class RentalStatusonetomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RentalVehicles_RentalStatusID",
                table: "RentalVehicles");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_RentalStatusID",
                table: "RentalVehicles",
                column: "RentalStatusID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RentalVehicles_RentalStatusID",
                table: "RentalVehicles");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_RentalStatusID",
                table: "RentalVehicles",
                column: "RentalStatusID",
                unique: true);
        }
    }
}
