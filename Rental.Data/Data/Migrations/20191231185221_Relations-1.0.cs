using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class Relations10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EquipmentID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "RentalAgencyID",
                table: "Vehicles");

            migrationBuilder.DropColumn(
                name: "GeneralTypeID",
                table: "ExactTypes");

            migrationBuilder.AddColumn<int>(
                name: "VehicleID",
                table: "RentalAgencies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VehicleID",
                table: "Equipment",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_BrandID",
                table: "Vehicles",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ColourID",
                table: "Vehicles",
                column: "ColourID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_EngineTypeID",
                table: "Vehicles",
                column: "EngineTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_ExactTypeID",
                table: "Vehicles",
                column: "ExactTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_GearBoxID",
                table: "Vehicles",
                column: "GearBoxID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_GeneralTypeID",
                table: "Vehicles",
                column: "GeneralTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleModelID",
                table: "Vehicles",
                column: "VehicleModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_WheelDriveID",
                table: "Vehicles",
                column: "WheelDriveID");

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
                name: "IX_Pictures_VehicleID",
                table: "Pictures",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_AirConditioningID",
                table: "Equipment",
                column: "AirConditioningID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_VehicleID",
                table: "Equipment",
                column: "VehicleID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CurrentPrices_VehicleID",
                table: "CurrentPrices",
                column: "VehicleID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_Vehicles_BrandID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ColourID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_EngineTypeID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_ExactTypeID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_GearBoxID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_GeneralTypeID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_VehicleModelID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_Vehicles_WheelDriveID",
                table: "Vehicles");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses");

            migrationBuilder.DropIndex(
                name: "IX_RentalAgencies_VehicleID",
                table: "RentalAgencies");

            migrationBuilder.DropIndex(
                name: "IX_Pictures_VehicleID",
                table: "Pictures");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_AirConditioningID",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_Equipment_VehicleID",
                table: "Equipment");

            migrationBuilder.DropIndex(
                name: "IX_CurrentPrices_VehicleID",
                table: "CurrentPrices");

            migrationBuilder.DropColumn(
                name: "VehicleID",
                table: "RentalAgencies");

            migrationBuilder.DropColumn(
                name: "VehicleID",
                table: "Equipment");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RentalAgencyID",
                table: "Vehicles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GeneralTypeID",
                table: "ExactTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
