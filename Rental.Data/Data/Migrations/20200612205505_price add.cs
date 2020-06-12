using Microsoft.EntityFrameworkCore.Migrations;

namespace Rental.Data
{
    public partial class priceadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "CurrentPrices");

            migrationBuilder.AddColumn<decimal>(
                name: "PriceDay",
                table: "CurrentPrices",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceLong",
                table: "CurrentPrices",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceWeek",
                table: "CurrentPrices",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceWeekend",
                table: "CurrentPrices",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PriceDay",
                table: "CurrentPrices");

            migrationBuilder.DropColumn(
                name: "PriceLong",
                table: "CurrentPrices");

            migrationBuilder.DropColumn(
                name: "PriceWeek",
                table: "CurrentPrices");

            migrationBuilder.DropColumn(
                name: "PriceWeekend",
                table: "CurrentPrices");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "CurrentPrices",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
