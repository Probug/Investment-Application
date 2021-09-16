using Microsoft.EntityFrameworkCore.Migrations;

namespace Bitmoonfasttrade.Migrations
{
    public partial class addBonus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Bonus",
                schema: "Identity",
                table: "Transaction",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bonus",
                schema: "Identity",
                table: "Transaction");
        }
    }
}
