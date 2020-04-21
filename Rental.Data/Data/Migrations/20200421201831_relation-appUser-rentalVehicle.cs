using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class relationappUserrentalVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserID",
                table: "RentalVehicles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "RentalVehicles",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalVehicles_Id",
                table: "RentalVehicles",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalVehicles_AspNetUsers_Id",
                table: "RentalVehicles",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalVehicles_AspNetUsers_Id",
                table: "RentalVehicles");

            migrationBuilder.DropIndex(
                name: "IX_RentalVehicles_Id",
                table: "RentalVehicles");

            migrationBuilder.DropColumn(
                name: "ApplicationUserID",
                table: "RentalVehicles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "RentalVehicles");
        }
    }
}
