using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class TableAndRelation1a : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirConditionings",
                columns: table => new
                {
                    AirConditioningID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditionings", x => x.AirConditioningID);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandID);
                });

            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    ColourID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.ColourID);
                });

            migrationBuilder.CreateTable(
                name: "EngineTypes",
                columns: table => new
                {
                    EngineTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EngineTypes", x => x.EngineTypeID);
                });

            migrationBuilder.CreateTable(
                name: "EquipmentNames",
                columns: table => new
                {
                    EquipmentNameID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentNames", x => x.EquipmentNameID);
                });

            migrationBuilder.CreateTable(
                name: "GearBoxes",
                columns: table => new
                {
                    GearBoxID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GearBoxes", x => x.GearBoxID);
                });

            migrationBuilder.CreateTable(
                name: "GeneralTypes",
                columns: table => new
                {
                    GeneralTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneralTypes", x => x.GeneralTypeID);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkName = table.Column<string>(maxLength: 20, nullable: false),
                    Title = table.Column<string>(maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Position = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsID);
                });

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    PageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LinkName = table.Column<string>(maxLength: 10, nullable: false),
                    Title = table.Column<string>(maxLength: 30, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    Position = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.PageID);
                });

            migrationBuilder.CreateTable(
                name: "RentalAgencies",
                columns: table => new
                {
                    RentalAgencyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactPerson = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Phone2 = table.Column<string>(nullable: true),
                    Email1 = table.Column<string>(nullable: true),
                    Email2 = table.Column<string>(nullable: true),
                    DateAdded = table.Column<DateTime>(type: "Date", nullable: true),
                    Annotation = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalAgencies", x => x.RentalAgencyID);
                });

            migrationBuilder.CreateTable(
                name: "WheelDrives",
                columns: table => new
                {
                    WheelDriveID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WheelDrives", x => x.WheelDriveID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleModels",
                columns: table => new
                {
                    VehicleModelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    BrandID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleModels", x => x.VehicleModelID);
                    table.ForeignKey(
                        name: "FK_VehicleModels_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ExactTypes",
                columns: table => new
                {
                    ExactTypeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GeneralTypeID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExactTypes", x => x.ExactTypeID);
                    table.ForeignKey(
                        name: "FK_ExactTypes_GeneralTypes_GeneralTypeID",
                        column: x => x.GeneralTypeID,
                        principalTable: "GeneralTypes",
                        principalColumn: "GeneralTypeID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentalAgencyAddresses",
                columns: table => new
                {
                    RentalAgencyAddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    ZIPCode = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    RentalAgencyID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentalAgencyAddresses", x => x.RentalAgencyAddressID);
                    table.ForeignKey(
                        name: "FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID",
                        column: x => x.RentalAgencyID,
                        principalTable: "RentalAgencies",
                        principalColumn: "RentalAgencyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandID = table.Column<int>(nullable: false),
                    VehicleModelID = table.Column<int>(nullable: false),
                    YearOfProduction = table.Column<DateTime>(type: "Date", nullable: true),
                    YearOfCarProduction = table.Column<int>(nullable: false),
                    RentalAgencyID = table.Column<int>(nullable: true),
                    EngineCapacity = table.Column<int>(nullable: true),
                    AirConditioningID = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GeneralTypeID = table.Column<int>(nullable: true),
                    ExactTypeID = table.Column<int>(nullable: true),
                    EngineTypeID = table.Column<int>(nullable: true),
                    Mileage = table.Column<string>(nullable: true),
                    ColourID = table.Column<int>(nullable: true),
                    VIN = table.Column<string>(nullable: true),
                    DateIn = table.Column<DateTime>(nullable: true),
                    DateOut = table.Column<DateTime>(nullable: true),
                    NumberPlate = table.Column<string>(nullable: true),
                    EnginePower = table.Column<int>(nullable: true),
                    GearBoxID = table.Column<int>(nullable: true),
                    WheelDriveID = table.Column<int>(nullable: true),
                    NumberOfSeats = table.Column<byte>(nullable: true),
                    NumberOfDoors = table.Column<byte>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                    table.ForeignKey(
                        name: "FK_Vehicles_AirConditionings_AirConditioningID",
                        column: x => x.AirConditioningID,
                        principalTable: "AirConditionings",
                        principalColumn: "AirConditioningID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Brands_BrandID",
                        column: x => x.BrandID,
                        principalTable: "Brands",
                        principalColumn: "BrandID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_Colours_ColourID",
                        column: x => x.ColourID,
                        principalTable: "Colours",
                        principalColumn: "ColourID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_EngineTypes_EngineTypeID",
                        column: x => x.EngineTypeID,
                        principalTable: "EngineTypes",
                        principalColumn: "EngineTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_ExactTypes_ExactTypeID",
                        column: x => x.ExactTypeID,
                        principalTable: "ExactTypes",
                        principalColumn: "ExactTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_GearBoxes_GearBoxID",
                        column: x => x.GearBoxID,
                        principalTable: "GearBoxes",
                        principalColumn: "GearBoxID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_GeneralTypes_GeneralTypeID",
                        column: x => x.GeneralTypeID,
                        principalTable: "GeneralTypes",
                        principalColumn: "GeneralTypeID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_RentalAgencies_RentalAgencyID",
                        column: x => x.RentalAgencyID,
                        principalTable: "RentalAgencies",
                        principalColumn: "RentalAgencyID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleModels_VehicleModelID",
                        column: x => x.VehicleModelID,
                        principalTable: "VehicleModels",
                        principalColumn: "VehicleModelID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicles_WheelDrives_WheelDriveID",
                        column: x => x.WheelDriveID,
                        principalTable: "WheelDrives",
                        principalColumn: "WheelDriveID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CurrentPrices",
                columns: table => new
                {
                    CurrentPriceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    DateTimeFrom = table.Column<DateTime>(nullable: true),
                    DateTimeTo = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentPrices", x => x.CurrentPriceID);
                    table.ForeignKey(
                        name: "FK_CurrentPrices_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    EquipmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(nullable: true),
                    EquipmentNameID = table.Column<int>(nullable: true),
                    Check = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.EquipmentID);
                    table.ForeignKey(
                        name: "FK_Equipment_EquipmentNames_EquipmentNameID",
                        column: x => x.EquipmentNameID,
                        principalTable: "EquipmentNames",
                        principalColumn: "EquipmentNameID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipment_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    PictureID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(nullable: true),
                    URL = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PictureID);
                    table.ForeignKey(
                        name: "FK_Pictures_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentPrices_VehicleID",
                table: "CurrentPrices",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_EquipmentNameID",
                table: "Equipment",
                column: "EquipmentNameID");

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_VehicleID",
                table: "Equipment",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_ExactTypes_GeneralTypeID",
                table: "ExactTypes",
                column: "GeneralTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_VehicleID",
                table: "Pictures",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_RentalAgencyAddresses_RentalAgencyID",
                table: "RentalAgencyAddresses",
                column: "RentalAgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleModels_BrandID",
                table: "VehicleModels",
                column: "BrandID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_AirConditioningID",
                table: "Vehicles",
                column: "AirConditioningID");

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
                name: "IX_Vehicles_RentalAgencyID",
                table: "Vehicles",
                column: "RentalAgencyID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleModelID",
                table: "Vehicles",
                column: "VehicleModelID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_WheelDriveID",
                table: "Vehicles",
                column: "WheelDriveID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentPrices");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "RentalAgencyAddresses");

            migrationBuilder.DropTable(
                name: "EquipmentNames");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "AirConditionings");

            migrationBuilder.DropTable(
                name: "Colours");

            migrationBuilder.DropTable(
                name: "EngineTypes");

            migrationBuilder.DropTable(
                name: "ExactTypes");

            migrationBuilder.DropTable(
                name: "GearBoxes");

            migrationBuilder.DropTable(
                name: "RentalAgencies");

            migrationBuilder.DropTable(
                name: "VehicleModels");

            migrationBuilder.DropTable(
                name: "WheelDrives");

            migrationBuilder.DropTable(
                name: "GeneralTypes");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
