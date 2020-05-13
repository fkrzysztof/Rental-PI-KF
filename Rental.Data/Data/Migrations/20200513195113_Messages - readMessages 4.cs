using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class MessagesreadMessages4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_Id",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_Id",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Messages",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_UserID",
                table: "Messages",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserID",
                table: "Messages",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_UserID",
                table: "Messages");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Messages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Id",
                table: "Messages",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Messages_Id",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_Id",
                table: "Messages",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
