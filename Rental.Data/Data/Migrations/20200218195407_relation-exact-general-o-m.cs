using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class relationexactgeneralom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeneralTypeID",
                table: "ExactTypes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExactTypes_GeneralTypeID",
                table: "ExactTypes",
                column: "GeneralTypeID");

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

            migrationBuilder.DropIndex(
                name: "IX_ExactTypes_GeneralTypeID",
                table: "ExactTypes");

            migrationBuilder.DropColumn(
                name: "GeneralTypeID",
                table: "ExactTypes");
        }
    }
}
