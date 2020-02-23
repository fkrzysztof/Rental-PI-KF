using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class yearOfCar_int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "YearOfProduction",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "Date",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "YearOfProduction",
                table: "Vehicles",
                type: "Date",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
