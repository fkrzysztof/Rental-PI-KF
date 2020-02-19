using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class RelationFull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentPrices_Vehicles_VehicleID",
                table: "CurrentPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_AirConditionings_AirConditioningID",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_Vehicles_VehicleID",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Vehicles_VehicleID",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgencies_Vehicles_VehicleID",
                table: "RentalAgencies");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                table: "RentalAgencyAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colours_ColourID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_EngineTypes_EngineTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_ExactTypes_ExactTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_GearBoxes_GearBoxID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_GeneralTypes_GeneralTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_WheelDrives_WheelDriveID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgencies_VehicleID",
                table: "RentalAgencies");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_VehicleID",
                table: "Equipment");

            migrationBuilder.DropColumn(
                name: "VehicleID",
                table: "RentalAgencies");

            migrationBuilder.DropColumn(
                name: "VehicleID",
                table: "Equipment");

            migrationBuilder.AlterColumn<int>(
                name: "WheelDriveID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GeneralTypeID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "GearBoxID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExactTypeID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EngineTypeID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ColourID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentID",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RentalAgencyID",
                table: "Vehicles",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "VehicleModels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RentalAgencyID",
                table: "RentalAgencyAddresses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Pictures",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AirConditioningID",
                table: "Equipment",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "CurrentPrices",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EquipmentID",
                table: "Vehicles",
                column: "EquipmentID",
                unique: true,
                filter: "[EquipmentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_RentalAgencyID",
                table: "Vehicles",
                column: "RentalAgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_BrandID",
                table: "VehicleModels",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID");

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentPrices_Vehicles_VehicleID",
                table: "CurrentPrices",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_AirConditionings_AirConditioningID",
                table: "Equipment",
                column: "AirConditioningID",
                principalTable: "AirConditionings",
                principalColumn: "AirConditioningID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Vehicles_VehicleID",
                table: "Pictures",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID",
                principalTable: "RentalAgencies",
                principalColumn: "RentalAgencyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VehicleModels_Brands_BrandID",
                table: "VehicleModels",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colours_ColourID",
                table: "Vehicles",
                column: "ColourID",
                principalTable: "Colours",
                principalColumn: "ColourID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_EngineTypes_EngineTypeID",
                table: "Vehicles",
                column: "EngineTypeID",
                principalTable: "EngineTypes",
                principalColumn: "EngineTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Equipment_EquipmentID",
                table: "Vehicles",
                column: "EquipmentID",
                principalTable: "Equipment",
                principalColumn: "EquipmentID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_ExactTypes_ExactTypeID",
                table: "Vehicles",
                column: "ExactTypeID",
                principalTable: "ExactTypes",
                principalColumn: "ExactTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_GearBoxes_GearBoxID",
                table: "Vehicles",
                column: "GearBoxID",
                principalTable: "GearBoxes",
                principalColumn: "GearBoxID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_GeneralTypes_GeneralTypeID",
                table: "Vehicles",
                column: "GeneralTypeID",
                principalTable: "GeneralTypes",
                principalColumn: "GeneralTypeID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_RentalAgencies_RentalAgencyID",
                table: "Vehicles",
                column: "RentalAgencyID",
                principalTable: "RentalAgencies",
                principalColumn: "RentalAgencyID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles",
                column: "VehicleModelID",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_WheelDrives_WheelDriveID",
                table: "Vehicles",
                column: "WheelDriveID",
                principalTable: "WheelDrives",
                principalColumn: "WheelDriveID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CurrentPrices_Vehicles_VehicleID",
                table: "CurrentPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipment_AirConditionings_AirConditioningID",
                table: "Equipment");

            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_Vehicles_VehicleID",
                table: "Pictures");

            migrationBuilder.DropForeignKey(
                name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                table: "RentalAgencyAddresses");

            migrationBuilder.DropForeignKey(
                name: "FK_VehicleModels_Brands_BrandID",
                table: "VehicleModels");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Colours_ColourID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_EngineTypes_EngineTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Equipment_EquipmentID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_ExactTypes_ExactTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_GearBoxes_GearBoxID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_GeneralTypes_GeneralTypeID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_RentalAgencies_RentalAgencyID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_WheelDrives_WheelDriveID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_EquipmentID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_RentalAgencyID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_VehicleModels_BrandID",
                table: "VehicleModels");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses");

            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "RentalAgencyID",
                table: "Vehicles");

            migrationBuilder.AlterColumn<int>(
                name: "WheelDriveID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModelID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GeneralTypeID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GearBoxID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExactTypeID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EngineTypeID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ColourID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BrandID",
                table: "VehicleModels",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RentalAgencyID",
                table: "RentalAgencyAddresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleID",
                table: "RentalAgencies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "Pictures",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AirConditioningID",
                table: "Equipment",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VehicleID",
                table: "Equipment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleID",
                table: "CurrentPrices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgencies_VehicleID",
                table: "RentalAgencies",
                column: "VehicleID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_VehicleID",
                table: "Equipment",
                column: "VehicleID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CurrentPrices_Vehicles_VehicleID",
                table: "CurrentPrices",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_AirConditionings_AirConditioningID",
                table: "Equipment",
                column: "AirConditioningID",
                principalTable: "AirConditionings",
                principalColumn: "AirConditioningID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipment_Vehicles_VehicleID",
                table: "Equipment",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_Vehicles_VehicleID",
                table: "Pictures",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgencies_Vehicles_VehicleID",
                table: "RentalAgencies",
                column: "VehicleID",
                principalTable: "Vehicles",
                principalColumn: "VehicleID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID",
                principalTable: "RentalAgencies",
                principalColumn: "RentalAgencyID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Brands_BrandID",
                table: "Vehicles",
                column: "BrandID",
                principalTable: "Brands",
                principalColumn: "BrandID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Colours_ColourID",
                table: "Vehicles",
                column: "ColourID",
                principalTable: "Colours",
                principalColumn: "ColourID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_EngineTypes_EngineTypeID",
                table: "Vehicles",
                column: "EngineTypeID",
                principalTable: "EngineTypes",
                principalColumn: "EngineTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_ExactTypes_ExactTypeID",
                table: "Vehicles",
                column: "ExactTypeID",
                principalTable: "ExactTypes",
                principalColumn: "ExactTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_GearBoxes_GearBoxID",
                table: "Vehicles",
                column: "GearBoxID",
                principalTable: "GearBoxes",
                principalColumn: "GearBoxID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_GeneralTypes_GeneralTypeID",
                table: "Vehicles",
                column: "GeneralTypeID",
                principalTable: "GeneralTypes",
                principalColumn: "GeneralTypeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_VehicleModels_VehicleModelID",
                table: "Vehicles",
                column: "VehicleModelID",
                principalTable: "VehicleModels",
                principalColumn: "VehicleModelID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_WheelDrives_WheelDriveID",
                table: "Vehicles",
                column: "WheelDriveID",
                principalTable: "WheelDrives",
                principalColumn: "WheelDriveID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
