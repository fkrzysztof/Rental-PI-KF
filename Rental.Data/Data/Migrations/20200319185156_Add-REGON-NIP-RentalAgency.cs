using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class AddREGONNIPRentalAgency : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NIP",
                table: "RentalAgencies",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "REGON",
                table: "RentalAgencies",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NIP",
                table: "RentalAgencies");

            migrationBuilder.DropColumn(
                name: "REGON",
                table: "RentalAgencies");
        }
    }
}
