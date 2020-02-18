using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class relationexactgeneralomnullexTy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExactTypes_GeneralTypes_GeneralTypeID",
                table: "ExactTypes");

            migrationBuilder.AlterColumn<int>(
                name: "GeneralTypeID",
                table: "ExactTypes",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ExactTypes_GeneralTypes_GeneralTypeID",
                table: "ExactTypes",
                column: "GeneralTypeID",
                principalTable: "GeneralTypes",
                principalColumn: "GeneralTypeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExactTypes_GeneralTypes_GeneralTypeID",
                table: "ExactTypes");

            migrationBuilder.AlterColumn<int>(
                name: "GeneralTypeID",
                table: "ExactTypes",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ExactTypes_GeneralTypes_GeneralTypeID",
                table: "ExactTypes",
                column: "GeneralTypeID",
                principalTable: "GeneralTypes",
                principalColumn: "GeneralTypeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
