using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class noMappedNameEquipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Equipment");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Equipment",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
