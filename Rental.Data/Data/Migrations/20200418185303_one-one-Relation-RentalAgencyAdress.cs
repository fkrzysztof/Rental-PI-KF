using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class oneoneRelationRentalAgencyAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalAgencyID",
                table: "RentalAgencyAddresses",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID",
                unique: true,
                filter: "[RentalAgencyID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID",
                principalTable: "RentalAgencies",
                principalColumn: "RentalAgencyID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                table: "RentalAgencyAddresses");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses");

            migrationBuilder.DropColumn(
                name: "RentalAgencyID",
                table: "RentalAgencyAddresses");
        }
    }
}
