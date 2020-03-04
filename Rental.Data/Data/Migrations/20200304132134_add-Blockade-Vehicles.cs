using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class addBlockadeVehicles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Blockade",
                table: "Vehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blockade",
                table: "Vehicles");
        }
    }
}
