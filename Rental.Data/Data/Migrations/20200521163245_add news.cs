using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class addnews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pages");

            migrationBuilder.DropColumn(
                name: "Content",
                table: "News");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "News");

            migrationBuilder.DropColumn(
                name: "LinkName",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "NewsContent",
                table: "News",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Topic",
                table: "News",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "News",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_News_UserID",
                table: "News",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_News_AspNetUsers_UserID",
                table: "News",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_News_AspNetUsers_UserID",
                table: "News");

            migrationBuilder.DropIndex(
                name: "IX_News_UserID",
                table: "News");

            migrationBuilder.DropColumn(
                name: "NewsContent",
                table: "News");

            migrationBuilder.DropColumn(
                name: "Topic",
                table: "News");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "News");

            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "News",
                type: "nvarchar(MAX)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "LinkName",
                table: "News",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Position",
                table: "News",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Pages",
                columns: table => new
                {
                    PageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(MAX)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LinkName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pages", x => x.PageID);
                });
        }
    }
}
