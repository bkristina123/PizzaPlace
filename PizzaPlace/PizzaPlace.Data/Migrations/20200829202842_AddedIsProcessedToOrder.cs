using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaPlace.Data.Migrations
{
    public partial class AddedIsProcessedToOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsProcessed",
                table: "Orders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsProcessed",
                table: "Orders");
        }
    }
}
