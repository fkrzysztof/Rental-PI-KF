using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class PriceremovedatetimeTo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTimeTo",
                table: "CurrentPrices");

            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte[]>(
                name: "Image",
                table: "Vehicles",
                type: "varbinary(max)",
                nullable: false,
                oldClrType: typeof(byte[]),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeTo",
                table: "CurrentPrices",
                type: "datetime2",
                nullable: true);
        }
    }
}
