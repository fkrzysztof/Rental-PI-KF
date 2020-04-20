using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class RentalVehicleaddFromLocationToLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalFromLocationId",
                table: "RentalVehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RentalToLocationId",
                table: "RentalVehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_RentalFromLocationId",
                table: "RentalVehicles",
                column: "RentalFromLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_RentalToLocationId",
                table: "RentalVehicles",
                column: "RentalToLocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalVehicles_RentalAgencyAddresses_RentalFromLocationId",
                table: "RentalVehicles",
                column: "RentalFromLocationId",
                principalTable: "RentalAgencyAddresses",
                principalColumn: "RentalAgencyAddressID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalVehicles_RentalAgencyAddresses_RentalToLocationId",
                table: "RentalVehicles",
                column: "RentalToLocationId",
                principalTable: "RentalAgencyAddresses",
                principalColumn: "RentalAgencyAddressID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalVehicles_RentalAgencyAddresses_RentalFromLocationId",
                table: "RentalVehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalVehicles_RentalAgencyAddresses_RentalToLocationId",
                table: "RentalVehicles");

            migrationBuilder.DropIndex(
                name: "IX_RentalVehicles_RentalFromLocationId",
                table: "RentalVehicles");

            migrationBuilder.DropIndex(
                name: "IX_RentalVehicles_RentalToLocationId",
                table: "RentalVehicles");

            migrationBuilder.DropColumn(
                name: "RentalFromLocationId",
                table: "RentalVehicles");

            migrationBuilder.DropColumn(
                name: "RentalToLocationId",
                table: "RentalVehicles");
        }
    }
}
