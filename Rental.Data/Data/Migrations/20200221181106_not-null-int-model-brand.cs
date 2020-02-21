using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class notnullintmodelbrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelID",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles",
                column: "VehicleModelID",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelID",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelID",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Vehicles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles",
                column: "VehicleModelID",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
