using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaPlace.Data.Migrations
{
    public partial class UpdatedOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "Orders",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phone",
                table: "Orders");
        }
    }
}
