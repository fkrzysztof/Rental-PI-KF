using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class removeRelationRentalAgencyAdress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RentalAgencyID",
                table: "RentalAgencyAddresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID");

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID",
                principalTable: "RentalAgencies",
                principalColumn: "RentalAgencyID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
