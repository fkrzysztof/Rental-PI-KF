IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [AspNetRoles] (
    [Id] nvarchar(450) NOT NULL,
    [Name] nvarchar(256) NULL,
    [NormalizedName] nvarchar(256) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetUsers] (
    [Id] nvarchar(450) NOT NULL,
    [UserName] nvarchar(256) NULL,
    [NormalizedUserName] nvarchar(256) NULL,
    [Email] nvarchar(256) NULL,
    [NormalizedEmail] nvarchar(256) NULL,
    [EmailConfirmed] bit NOT NULL,
    [PasswordHash] nvarchar(max) NULL,
    [SecurityStamp] nvarchar(max) NULL,
    [ConcurrencyStamp] nvarchar(max) NULL,
    [PhoneNumber] nvarchar(max) NULL,
    [PhoneNumberConfirmed] bit NOT NULL,
    [TwoFactorEnabled] bit NOT NULL,
    [LockoutEnd] datetimeoffset NULL,
    [LockoutEnabled] bit NOT NULL,
    [AccessFailedCount] int NOT NULL,
    CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [AspNetRoleClaims] (
    [Id] int NOT NULL IDENTITY,
    [RoleId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserClaims] (
    [Id] int NOT NULL IDENTITY,
    [UserId] nvarchar(450) NOT NULL,
    [ClaimType] nvarchar(max) NULL,
    [ClaimValue] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserLogins] (
    [LoginProvider] nvarchar(128) NOT NULL,
    [ProviderKey] nvarchar(128) NOT NULL,
    [ProviderDisplayName] nvarchar(max) NULL,
    [UserId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
    CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserRoles] (
    [UserId] nvarchar(450) NOT NULL,
    [RoleId] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
    CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE TABLE [AspNetUserTokens] (
    [UserId] nvarchar(450) NOT NULL,
    [LoginProvider] nvarchar(128) NOT NULL,
    [Name] nvarchar(128) NOT NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
    CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);

GO

CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;

GO

CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);

GO

CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);

GO

CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);

GO

CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.0');

GO

CREATE TABLE [AirConditionings] (
    [AirConditioningID] int NOT NULL IDENTITY,
    [Type] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_AirConditionings] PRIMARY KEY ([AirConditioningID])
);

GO

CREATE TABLE [Brands] (
    [BrandID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY ([BrandID])
);

GO

CREATE TABLE [Colours] (
    [ColourID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_Colours] PRIMARY KEY ([ColourID])
);

GO

CREATE TABLE [EngineTypes] (
    [EngineTypeID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_EngineTypes] PRIMARY KEY ([EngineTypeID])
);

GO

CREATE TABLE [ExactTypes] (
    [ExactTypeID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_ExactTypes] PRIMARY KEY ([ExactTypeID])
);

GO

CREATE TABLE [GearBoxes] (
    [GearBoxID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_GearBoxes] PRIMARY KEY ([GearBoxID])
);

GO

CREATE TABLE [GeneralTypes] (
    [GeneralTypeID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_GeneralTypes] PRIMARY KEY ([GeneralTypeID])
);

GO

CREATE TABLE [News] (
    [NewsID] int NOT NULL IDENTITY,
    [LinkName] nvarchar(20) NOT NULL,
    [Title] nvarchar(30) NOT NULL,
    [Content] nvarchar(MAX) NULL,
    [Position] int NOT NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_News] PRIMARY KEY ([NewsID])
);

GO

CREATE TABLE [Pages] (
    [PageID] int NOT NULL IDENTITY,
    [LinkName] nvarchar(10) NOT NULL,
    [Title] nvarchar(30) NOT NULL,
    [Content] nvarchar(MAX) NULL,
    [Position] int NOT NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_Pages] PRIMARY KEY ([PageID])
);

GO

CREATE TABLE [VehicleModels] (
    [VehicleModelID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    [BrandID] int NOT NULL,
    CONSTRAINT [PK_VehicleModels] PRIMARY KEY ([VehicleModelID])
);

GO

CREATE TABLE [WheelDrives] (
    [WheelDriveID] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Description] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_WheelDrives] PRIMARY KEY ([WheelDriveID])
);

GO

CREATE TABLE [Vehicles] (
    [VehicleID] int NOT NULL IDENTITY,
    [BrandID] int NOT NULL,
    [VehicleModelID] int NOT NULL,
    [YearOfProduction] datetime2 NULL,
    [EngineCapacity] int NULL,
    [Description] nvarchar(max) NULL,
    [GeneralTypeID] int NOT NULL,
    [ExactTypeID] int NOT NULL,
    [EngineTypeID] int NOT NULL,
    [Mileage] nvarchar(max) NULL,
    [ColourID] int NOT NULL,
    [VIN] nvarchar(max) NULL,
    [DateIn] datetime2 NULL,
    [DateOut] datetime2 NULL,
    [NumberPlate] nvarchar(max) NULL,
    [EnginePower] int NULL,
    [GearBoxID] int NOT NULL,
    [WheelDriveID] int NOT NULL,
    [NumberOfSeats] tinyint NULL,
    [NumberOfDoors] tinyint NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_Vehicles] PRIMARY KEY ([VehicleID]),
    CONSTRAINT [FK_Vehicles_Brands_BrandID] FOREIGN KEY ([BrandID]) REFERENCES [Brands] ([BrandID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Vehicles_Colours_ColourID] FOREIGN KEY ([ColourID]) REFERENCES [Colours] ([ColourID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Vehicles_EngineTypes_EngineTypeID] FOREIGN KEY ([EngineTypeID]) REFERENCES [EngineTypes] ([EngineTypeID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Vehicles_ExactTypes_ExactTypeID] FOREIGN KEY ([ExactTypeID]) REFERENCES [ExactTypes] ([ExactTypeID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Vehicles_GearBoxes_GearBoxID] FOREIGN KEY ([GearBoxID]) REFERENCES [GearBoxes] ([GearBoxID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Vehicles_GeneralTypes_GeneralTypeID] FOREIGN KEY ([GeneralTypeID]) REFERENCES [GeneralTypes] ([GeneralTypeID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Vehicles_VehicleModels_VehicleModelID] FOREIGN KEY ([VehicleModelID]) REFERENCES [VehicleModels] ([VehicleModelID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Vehicles_WheelDrives_WheelDriveID] FOREIGN KEY ([WheelDriveID]) REFERENCES [WheelDrives] ([WheelDriveID]) ON DELETE CASCADE
);

GO

CREATE TABLE [CurrentPrices] (
    [CurrentPriceID] int NOT NULL IDENTITY,
    [VehicleID] int NOT NULL,
    [Price] decimal(18,2) NULL,
    [DateTimeFrom] datetime2 NULL,
    [DateTimeTo] datetime2 NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_CurrentPrices] PRIMARY KEY ([CurrentPriceID]),
    CONSTRAINT [FK_CurrentPrices_Vehicles_VehicleID] FOREIGN KEY ([VehicleID]) REFERENCES [Vehicles] ([VehicleID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Equipment] (
    [EquipmentID] int NOT NULL IDENTITY,
    [ABS] bit NULL,
    [AUX] bit NULL,
    [ISOFIX] bit NULL,
    [CD] bit NULL,
    [SD] bit NULL,
    [USB] bit NULL,
    [CruiseControl] bit NULL,
    [Navigation] bit NULL,
    [Airbag] bit NULL,
    [PowerSteering] bit NULL,
    [AirConditioningID] int NOT NULL,
    [VehicleID] int NOT NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_Equipment] PRIMARY KEY ([EquipmentID]),
    CONSTRAINT [FK_Equipment_AirConditionings_AirConditioningID] FOREIGN KEY ([AirConditioningID]) REFERENCES [AirConditionings] ([AirConditioningID]) ON DELETE CASCADE,
    CONSTRAINT [FK_Equipment_Vehicles_VehicleID] FOREIGN KEY ([VehicleID]) REFERENCES [Vehicles] ([VehicleID]) ON DELETE CASCADE
);

GO

CREATE TABLE [Pictures] (
    [PictureID] int NOT NULL IDENTITY,
    [VehicleID] int NOT NULL,
    [URL] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    CONSTRAINT [PK_Pictures] PRIMARY KEY ([PictureID]),
    CONSTRAINT [FK_Pictures_Vehicles_VehicleID] FOREIGN KEY ([VehicleID]) REFERENCES [Vehicles] ([VehicleID]) ON DELETE CASCADE
);

GO

CREATE TABLE [RentalAgencies] (
    [RentalAgencyID] int NOT NULL IDENTITY,
    [ContactPerson] nvarchar(max) NULL,
    [Number] nvarchar(max) NULL,
    [Name] nvarchar(max) NULL,
    [Phone1] nvarchar(max) NULL,
    [Phone2] nvarchar(max) NULL,
    [Email1] nvarchar(max) NULL,
    [Email2] nvarchar(max) NULL,
    [DateAdded] datetime2 NULL,
    [Annotation] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    [VehicleID] int NOT NULL,
    CONSTRAINT [PK_RentalAgencies] PRIMARY KEY ([RentalAgencyID]),
    CONSTRAINT [FK_RentalAgencies_Vehicles_VehicleID] FOREIGN KEY ([VehicleID]) REFERENCES [Vehicles] ([VehicleID]) ON DELETE CASCADE
);

GO

CREATE TABLE [RentalAgencyAddresses] (
    [RentalAgencyAddressID] int NOT NULL IDENTITY,
    [Country] nvarchar(max) NULL,
    [City] nvarchar(max) NULL,
    [Street] nvarchar(max) NULL,
    [Number] nvarchar(max) NULL,
    [ZIPCode] nvarchar(max) NULL,
    [IsActive] bit NOT NULL,
    [RentalAgencyID] int NOT NULL,
    CONSTRAINT [PK_RentalAgencyAddresses] PRIMARY KEY ([RentalAgencyAddressID]),
    CONSTRAINT [FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID] FOREIGN KEY ([RentalAgencyID]) REFERENCES [RentalAgencies] ([RentalAgencyID]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_CurrentPrices_VehicleID] ON [CurrentPrices] ([VehicleID]);

GO

CREATE INDEX [IX_Equipment_AirConditioningID] ON [Equipment] ([AirConditioningID]);

GO

CREATE UNIQUE INDEX [IX_Equipment_VehicleID] ON [Equipment] ([VehicleID]);

GO

CREATE INDEX [IX_Pictures_VehicleID] ON [Pictures] ([VehicleID]);

GO

CREATE UNIQUE INDEX [IX_RentalAgencies_VehicleID] ON [RentalAgencies] ([VehicleID]);

GO

CREATE UNIQUE INDEX [IX_RentalAgencyAddresses_RentalAgencyID] ON [RentalAgencyAddresses] ([RentalAgencyID]);

GO

CREATE INDEX [IX_Vehicles_BrandID] ON [Vehicles] ([BrandID]);

GO

CREATE INDEX [IX_Vehicles_ColourID] ON [Vehicles] ([ColourID]);

GO

CREATE INDEX [IX_Vehicles_EngineTypeID] ON [Vehicles] ([EngineTypeID]);

GO

CREATE INDEX [IX_Vehicles_ExactTypeID] ON [Vehicles] ([ExactTypeID]);

GO

CREATE INDEX [IX_Vehicles_GearBoxID] ON [Vehicles] ([GearBoxID]);

GO

CREATE INDEX [IX_Vehicles_GeneralTypeID] ON [Vehicles] ([GeneralTypeID]);

GO

CREATE INDEX [IX_Vehicles_VehicleModelID] ON [Vehicles] ([VehicleModelID]);

GO

CREATE INDEX [IX_Vehicles_WheelDriveID] ON [Vehicles] ([WheelDriveID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200101204857_Database-basic-1.0', N'3.1.0');

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'YearOfProduction');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [YearOfProduction] Date NULL;

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RentalAgencies]') AND [c].[name] = N'DateAdded');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [RentalAgencies] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [RentalAgencies] ALTER COLUMN [DateAdded] Date NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200218185025_TypeName=date-Vehicle_RentalAgency', N'3.1.0');

GO

ALTER TABLE [ExactTypes] ADD [GeneralTypeID] int NOT NULL DEFAULT 0;

GO

CREATE INDEX [IX_ExactTypes_GeneralTypeID] ON [ExactTypes] ([GeneralTypeID]);

GO

ALTER TABLE [ExactTypes] ADD CONSTRAINT [FK_ExactTypes_GeneralTypes_GeneralTypeID] FOREIGN KEY ([GeneralTypeID]) REFERENCES [GeneralTypes] ([GeneralTypeID]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200218195407_relation-exact-general-o-m', N'3.1.0');

GO

ALTER TABLE [ExactTypes] DROP CONSTRAINT [FK_ExactTypes_GeneralTypes_GeneralTypeID];

GO

DECLARE @var2 sysname;
SELECT @var2 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[ExactTypes]') AND [c].[name] = N'GeneralTypeID');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [ExactTypes] DROP CONSTRAINT [' + @var2 + '];');
ALTER TABLE [ExactTypes] ALTER COLUMN [GeneralTypeID] int NULL;

GO

ALTER TABLE [ExactTypes] ADD CONSTRAINT [FK_ExactTypes_GeneralTypes_GeneralTypeID] FOREIGN KEY ([GeneralTypeID]) REFERENCES [GeneralTypes] ([GeneralTypeID]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200218205114_relation-exact-general-o-m-null-exTy', N'3.1.0');

GO

ALTER TABLE [CurrentPrices] DROP CONSTRAINT [FK_CurrentPrices_Vehicles_VehicleID];

GO

ALTER TABLE [Equipment] DROP CONSTRAINT [FK_Equipment_AirConditionings_AirConditioningID];

GO

ALTER TABLE [Equipment] DROP CONSTRAINT [FK_Equipment_Vehicles_VehicleID];

GO

ALTER TABLE [Pictures] DROP CONSTRAINT [FK_Pictures_Vehicles_VehicleID];

GO

ALTER TABLE [RentalAgencies] DROP CONSTRAINT [FK_RentalAgencies_Vehicles_VehicleID];

GO

ALTER TABLE [RentalAgencyAddresses] DROP CONSTRAINT [FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_Brands_BrandID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_Colours_ColourID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_EngineTypes_EngineTypeID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_ExactTypes_ExactTypeID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_GearBoxes_GearBoxID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_GeneralTypes_GeneralTypeID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_VehicleModels_VehicleModelID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_WheelDrives_WheelDriveID];

GO

DROP INDEX [IX_RentalAgencyAddresses_RentalAgencyID] ON [RentalAgencyAddresses];

GO

DROP INDEX [IX_RentalAgencies_VehicleID] ON [RentalAgencies];

GO

DROP INDEX [IX_Equipment_VehicleID] ON [Equipment];

GO

DECLARE @var3 sysname;
SELECT @var3 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RentalAgencies]') AND [c].[name] = N'VehicleID');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [RentalAgencies] DROP CONSTRAINT [' + @var3 + '];');
ALTER TABLE [RentalAgencies] DROP COLUMN [VehicleID];

GO

DECLARE @var4 sysname;
SELECT @var4 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'VehicleID');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var4 + '];');
ALTER TABLE [Equipment] DROP COLUMN [VehicleID];

GO

DECLARE @var5 sysname;
SELECT @var5 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'WheelDriveID');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var5 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [WheelDriveID] int NULL;

GO

DECLARE @var6 sysname;
SELECT @var6 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'VehicleModelID');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var6 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [VehicleModelID] int NULL;

GO

DECLARE @var7 sysname;
SELECT @var7 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'GeneralTypeID');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var7 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [GeneralTypeID] int NULL;

GO

DECLARE @var8 sysname;
SELECT @var8 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'GearBoxID');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var8 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [GearBoxID] int NULL;

GO

DECLARE @var9 sysname;
SELECT @var9 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'ExactTypeID');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var9 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [ExactTypeID] int NULL;

GO

DECLARE @var10 sysname;
SELECT @var10 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'EngineTypeID');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var10 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [EngineTypeID] int NULL;

GO

DECLARE @var11 sysname;
SELECT @var11 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'ColourID');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var11 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [ColourID] int NULL;

GO

DECLARE @var12 sysname;
SELECT @var12 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'BrandID');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var12 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [BrandID] int NULL;

GO

ALTER TABLE [Vehicles] ADD [EquipmentID] int NULL;

GO

ALTER TABLE [Vehicles] ADD [RentalAgencyID] int NULL;

GO

DECLARE @var13 sysname;
SELECT @var13 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[VehicleModels]') AND [c].[name] = N'BrandID');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [VehicleModels] DROP CONSTRAINT [' + @var13 + '];');
ALTER TABLE [VehicleModels] ALTER COLUMN [BrandID] int NULL;

GO

DECLARE @var14 sysname;
SELECT @var14 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[RentalAgencyAddresses]') AND [c].[name] = N'RentalAgencyID');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [RentalAgencyAddresses] DROP CONSTRAINT [' + @var14 + '];');
ALTER TABLE [RentalAgencyAddresses] ALTER COLUMN [RentalAgencyID] int NULL;

GO

DECLARE @var15 sysname;
SELECT @var15 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Pictures]') AND [c].[name] = N'VehicleID');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Pictures] DROP CONSTRAINT [' + @var15 + '];');
ALTER TABLE [Pictures] ALTER COLUMN [VehicleID] int NULL;

GO

DECLARE @var16 sysname;
SELECT @var16 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'AirConditioningID');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var16 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [AirConditioningID] int NULL;

GO

DECLARE @var17 sysname;
SELECT @var17 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[CurrentPrices]') AND [c].[name] = N'VehicleID');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [CurrentPrices] DROP CONSTRAINT [' + @var17 + '];');
ALTER TABLE [CurrentPrices] ALTER COLUMN [VehicleID] int NULL;

GO

CREATE UNIQUE INDEX [IX_Vehicles_EquipmentID] ON [Vehicles] ([EquipmentID]) WHERE [EquipmentID] IS NOT NULL;

GO

CREATE INDEX [IX_Vehicles_RentalAgencyID] ON [Vehicles] ([RentalAgencyID]);

GO

CREATE INDEX [IX_VehicleModels_BrandID] ON [VehicleModels] ([BrandID]);

GO

CREATE INDEX [IX_RentalAgencyAddresses_RentalAgencyID] ON [RentalAgencyAddresses] ([RentalAgencyID]);

GO

ALTER TABLE [CurrentPrices] ADD CONSTRAINT [FK_CurrentPrices_Vehicles_VehicleID] FOREIGN KEY ([VehicleID]) REFERENCES [Vehicles] ([VehicleID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Equipment] ADD CONSTRAINT [FK_Equipment_AirConditionings_AirConditioningID] FOREIGN KEY ([AirConditioningID]) REFERENCES [AirConditionings] ([AirConditioningID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Pictures] ADD CONSTRAINT [FK_Pictures_Vehicles_VehicleID] FOREIGN KEY ([VehicleID]) REFERENCES [Vehicles] ([VehicleID]) ON DELETE NO ACTION;

GO

ALTER TABLE [RentalAgencyAddresses] ADD CONSTRAINT [FK_RentalAgencyAddresses_RentalAgencies_RentalAgencyID] FOREIGN KEY ([RentalAgencyID]) REFERENCES [RentalAgencies] ([RentalAgencyID]) ON DELETE NO ACTION;

GO

ALTER TABLE [VehicleModels] ADD CONSTRAINT [FK_VehicleModels_Brands_BrandID] FOREIGN KEY ([BrandID]) REFERENCES [Brands] ([BrandID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_Brands_BrandID] FOREIGN KEY ([BrandID]) REFERENCES [Brands] ([BrandID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_Colours_ColourID] FOREIGN KEY ([ColourID]) REFERENCES [Colours] ([ColourID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_EngineTypes_EngineTypeID] FOREIGN KEY ([EngineTypeID]) REFERENCES [EngineTypes] ([EngineTypeID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_Equipment_EquipmentID] FOREIGN KEY ([EquipmentID]) REFERENCES [Equipment] ([EquipmentID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_ExactTypes_ExactTypeID] FOREIGN KEY ([ExactTypeID]) REFERENCES [ExactTypes] ([ExactTypeID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_GearBoxes_GearBoxID] FOREIGN KEY ([GearBoxID]) REFERENCES [GearBoxes] ([GearBoxID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_GeneralTypes_GeneralTypeID] FOREIGN KEY ([GeneralTypeID]) REFERENCES [GeneralTypes] ([GeneralTypeID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_RentalAgencies_RentalAgencyID] FOREIGN KEY ([RentalAgencyID]) REFERENCES [RentalAgencies] ([RentalAgencyID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_VehicleModels_VehicleModelID] FOREIGN KEY ([VehicleModelID]) REFERENCES [VehicleModels] ([VehicleModelID]) ON DELETE NO ACTION;

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_WheelDrives_WheelDriveID] FOREIGN KEY ([WheelDriveID]) REFERENCES [WheelDrives] ([WheelDriveID]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200219181208_Relation-Full', N'3.1.0');

GO

DECLARE @var18 sysname;
SELECT @var18 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'USB');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var18 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [USB] bit NOT NULL;

GO

DECLARE @var19 sysname;
SELECT @var19 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'SD');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var19 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [SD] bit NOT NULL;

GO

DECLARE @var20 sysname;
SELECT @var20 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'PowerSteering');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var20 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [PowerSteering] bit NOT NULL;

GO

DECLARE @var21 sysname;
SELECT @var21 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'Navigation');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var21 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [Navigation] bit NOT NULL;

GO

DECLARE @var22 sysname;
SELECT @var22 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'ISOFIX');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var22 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [ISOFIX] bit NOT NULL;

GO

DECLARE @var23 sysname;
SELECT @var23 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'CruiseControl');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var23 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [CruiseControl] bit NOT NULL;

GO

DECLARE @var24 sysname;
SELECT @var24 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'CD');
IF @var24 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var24 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [CD] bit NOT NULL;

GO

DECLARE @var25 sysname;
SELECT @var25 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'Airbag');
IF @var25 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var25 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [Airbag] bit NOT NULL;

GO

DECLARE @var26 sysname;
SELECT @var26 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'AUX');
IF @var26 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var26 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [AUX] bit NOT NULL;

GO

DECLARE @var27 sysname;
SELECT @var27 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Equipment]') AND [c].[name] = N'ABS');
IF @var27 IS NOT NULL EXEC(N'ALTER TABLE [Equipment] DROP CONSTRAINT [' + @var27 + '];');
ALTER TABLE [Equipment] ALTER COLUMN [ABS] bit NOT NULL;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200219183413_Equipments-only-bool', N'3.1.0');

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_Brands_BrandID];

GO

ALTER TABLE [Vehicles] DROP CONSTRAINT [FK_Vehicles_VehicleModels_VehicleModelID];

GO

DROP INDEX [IX_Vehicles_VehicleModelID] ON [Vehicles];
DECLARE @var28 sysname;
SELECT @var28 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'VehicleModelID');
IF @var28 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var28 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [VehicleModelID] int NOT NULL;
CREATE INDEX [IX_Vehicles_VehicleModelID] ON [Vehicles] ([VehicleModelID]);

GO

DROP INDEX [IX_Vehicles_BrandID] ON [Vehicles];
DECLARE @var29 sysname;
SELECT @var29 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Vehicles]') AND [c].[name] = N'BrandID');
IF @var29 IS NOT NULL EXEC(N'ALTER TABLE [Vehicles] DROP CONSTRAINT [' + @var29 + '];');
ALTER TABLE [Vehicles] ALTER COLUMN [BrandID] int NOT NULL;
CREATE INDEX [IX_Vehicles_BrandID] ON [Vehicles] ([BrandID]);

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_Brands_BrandID] FOREIGN KEY ([BrandID]) REFERENCES [Brands] ([BrandID]);

GO

ALTER TABLE [Vehicles] ADD CONSTRAINT [FK_Vehicles_VehicleModels_VehicleModelID] FOREIGN KEY ([VehicleModelID]) REFERENCES [VehicleModels] ([VehicleModelID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200221181106_not-null-int-model-brand', N'3.1.0');

GO

ALTER TABLE [Vehicles] ADD [YearOfCarProduction] int NOT NULL DEFAULT 0;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200223194136_YearOfCarProduction-int-add', N'3.1.0');

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200223203213_Display-Name-Vehicle', N'3.1.0');

GO

