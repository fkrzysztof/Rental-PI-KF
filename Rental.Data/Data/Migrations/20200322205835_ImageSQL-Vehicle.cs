using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class ImageSQLVehicle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Vehicles",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Vehicles");
        }
    }
}
