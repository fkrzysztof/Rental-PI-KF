﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rental.Data;

namespace Rental.Data
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Rental.Data.Data.Areas.Identity.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("ZIPCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Rental.Data.Data.Rental.EquipmentName", b =>
                {
                    b.Property<int>("EquipmentNameID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EquipmentNameID");

                    b.ToTable("EquipmentNames");
                });

            modelBuilder.Entity("Rental.Data.Data.Rental.RentalStatus", b =>
                {
                    b.Property<int>("RentalStatusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RentalStatusID");

                    b.ToTable("RentalStatuses");
                });

            modelBuilder.Entity("Rental.Data.Data.Rental.RentalVehicle", b =>
                {
                    b.Property<int>("RentalVehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("From")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int>("RentalStatusID")
                        .HasColumnType("int");

                    b.Property<DateTime>("To")
                        .HasColumnType("datetime2");

                    b.Property<int>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("RentalVehicleID");

                    b.HasIndex("RentalStatusID");

                    b.HasIndex("VehicleID");

                    b.ToTable("RentalVehicles");
                });

            modelBuilder.Entity("Rental_Data.Data.CMS.News", b =>
                {
                    b.Property<int>("NewsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("NewsID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Rental_Data.Data.CMS.Page", b =>
                {
                    b.Property<int>("PageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(MAX)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("LinkName")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("PageID");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.AirConditioning", b =>
                {
                    b.Property<int>("AirConditioningID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AirConditioningID");

                    b.ToTable("AirConditionings");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Brand", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandID");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Colour", b =>
                {
                    b.Property<int>("ColourID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColourID");

                    b.ToTable("Colours");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.CurrentPrice", b =>
                {
                    b.Property<int>("CurrentPriceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DateTimeFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateTimeTo")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("CurrentPriceID");

                    b.HasIndex("VehicleID");

                    b.ToTable("CurrentPrices");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.EngineType", b =>
                {
                    b.Property<int>("EngineTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EngineTypeID");

                    b.ToTable("EngineTypes");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Equipment", b =>
                {
                    b.Property<int>("EquipmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Check")
                        .HasColumnType("bit");

                    b.Property<int?>("EquipmentNameID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<int?>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("EquipmentID");

                    b.HasIndex("EquipmentNameID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.ExactType", b =>
                {
                    b.Property<int>("ExactTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GeneralTypeID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ExactTypeID");

                    b.HasIndex("GeneralTypeID");

                    b.ToTable("ExactTypes");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.GearBox", b =>
                {
                    b.Property<int>("GearBoxID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GearBoxID");

                    b.ToTable("GearBoxes");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.GeneralType", b =>
                {
                    b.Property<int>("GeneralTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("GeneralTypeID");

                    b.ToTable("GeneralTypes");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Picture", b =>
                {
                    b.Property<int>("PictureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VehicleID")
                        .HasColumnType("int");

                    b.HasKey("PictureID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.RentalAgency", b =>
                {
                    b.Property<int>("RentalAgencyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Annotation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactPerson")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateAdded")
                        .HasColumnType("Date");

                    b.Property<string>("Email1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("NIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REGON")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RentalAgencyID");

                    b.ToTable("RentalAgencies");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.RentalAgencyAddress", b =>
                {
                    b.Property<int>("RentalAgencyAddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RentalAgencyID")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZIPCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RentalAgencyAddressID");

                    b.HasIndex("RentalAgencyID");

                    b.ToTable("RentalAgencyAddresses");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AirConditioningID")
                        .HasColumnType("int");

                    b.Property<bool?>("Blockade")
                        .HasColumnType("bit");

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<int?>("ColourID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateOut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EngineCapacity")
                        .HasColumnType("int");

                    b.Property<int?>("EnginePower")
                        .HasColumnType("int");

                    b.Property<int?>("EngineTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("ExactTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("GearBoxID")
                        .HasColumnType("int");

                    b.Property<int?>("GeneralTypeID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Mileage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte?>("NumberOfDoors")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("NumberOfSeats")
                        .HasColumnType("tinyint");

                    b.Property<string>("NumberPlate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RentalAgencyID")
                        .HasColumnType("int");

                    b.Property<string>("VIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleModelID")
                        .HasColumnType("int");

                    b.Property<int?>("WheelDriveID")
                        .HasColumnType("int");

                    b.Property<int>("YearOfCarProduction")
                        .HasColumnType("int");

                    b.Property<DateTime?>("YearOfProduction")
                        .HasColumnType("Date");

                    b.HasKey("VehicleID");

                    b.HasIndex("AirConditioningID");

                    b.HasIndex("BrandID");

                    b.HasIndex("ColourID");

                    b.HasIndex("EngineTypeID");

                    b.HasIndex("ExactTypeID");

                    b.HasIndex("GearBoxID");

                    b.HasIndex("GeneralTypeID");

                    b.HasIndex("RentalAgencyID");

                    b.HasIndex("VehicleModelID");

                    b.HasIndex("WheelDriveID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.VehicleModel", b =>
                {
                    b.Property<int>("VehicleModelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BrandID")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VehicleModelID");

                    b.HasIndex("BrandID");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.WheelDrive", b =>
                {
                    b.Property<int>("WheelDriveID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WheelDriveID");

                    b.ToTable("WheelDrives");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Rental.Data.Data.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Rental.Data.Data.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rental.Data.Data.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Rental.Data.Data.Areas.Identity.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rental.Data.Data.Rental.RentalVehicle", b =>
                {
                    b.HasOne("Rental.Data.Data.Rental.RentalStatus", "RentalStatus")
                        .WithMany("RentalVehicle")
                        .HasForeignKey("RentalStatusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rental_Data.Data.Rental.Vehicle", "Vehicle")
                        .WithMany("RentalVehicles")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.CurrentPrice", b =>
                {
                    b.HasOne("Rental_Data.Data.Rental.Vehicle", "Vehicle")
                        .WithMany("CurrentPrices")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Equipment", b =>
                {
                    b.HasOne("Rental.Data.Data.Rental.EquipmentName", "EquipmentName")
                        .WithMany("Equipment")
                        .HasForeignKey("EquipmentNameID");

                    b.HasOne("Rental_Data.Data.Rental.Vehicle", "Vehicle")
                        .WithMany("Equipment")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.ExactType", b =>
                {
                    b.HasOne("Rental_Data.Data.Rental.GeneralType", "GeneralType")
                        .WithMany("ExactTypes")
                        .HasForeignKey("GeneralTypeID");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Picture", b =>
                {
                    b.HasOne("Rental_Data.Data.Rental.Vehicle", "Vehicle")
                        .WithMany("Pictures")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.RentalAgencyAddress", b =>
                {
                    b.HasOne("Rental_Data.Data.Rental.RentalAgency", "RentalAgency")
                        .WithMany("RentalAgencyAddress")
                        .HasForeignKey("RentalAgencyID");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.Vehicle", b =>
                {
                    b.HasOne("Rental_Data.Data.Rental.AirConditioning", "AirConditioning")
                        .WithMany("Vehicle")
                        .HasForeignKey("AirConditioningID");

                    b.HasOne("Rental_Data.Data.Rental.Brand", "Brand")
                        .WithMany("Vehicles")
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rental_Data.Data.Rental.Colour", "Colour")
                        .WithMany("Vehicles")
                        .HasForeignKey("ColourID");

                    b.HasOne("Rental_Data.Data.Rental.EngineType", "EngineType")
                        .WithMany()
                        .HasForeignKey("EngineTypeID");

                    b.HasOne("Rental_Data.Data.Rental.ExactType", "ExactType")
                        .WithMany("Vehicles")
                        .HasForeignKey("ExactTypeID");

                    b.HasOne("Rental_Data.Data.Rental.GearBox", "GearBox")
                        .WithMany("Vehicles")
                        .HasForeignKey("GearBoxID");

                    b.HasOne("Rental_Data.Data.Rental.GeneralType", "GeneralType")
                        .WithMany("Vehicles")
                        .HasForeignKey("GeneralTypeID");

                    b.HasOne("Rental_Data.Data.Rental.RentalAgency", "RentalAgency")
                        .WithMany("Vehicles")
                        .HasForeignKey("RentalAgencyID");

                    b.HasOne("Rental_Data.Data.Rental.VehicleModel", "VehicleModel")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleModelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rental_Data.Data.Rental.WheelDrive", "WheelDrive")
                        .WithMany("Vehicles")
                        .HasForeignKey("WheelDriveID");
                });

            modelBuilder.Entity("Rental_Data.Data.Rental.VehicleModel", b =>
                {
                    b.HasOne("Rental_Data.Data.Rental.Brand", "Brand")
                        .WithMany("VehicleModel")
                        .HasForeignKey("BrandID");
                });
#pragma warning restore 612, 618
        }
    }
}
