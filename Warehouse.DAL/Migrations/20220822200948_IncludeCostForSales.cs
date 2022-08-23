using Microsoft.EntityFrameworkCore.Migrations;

namespace Warehouse.DAL.Migrations
{
    public partial class IncludeCostForSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CurrentCost",
                table: "Sales",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrentCost",
                table: "Sales");
        }
    }
}
