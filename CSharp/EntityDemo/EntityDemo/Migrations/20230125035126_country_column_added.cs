using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDemo.Migrations
{
    public partial class country_column_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "CustomerDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "CustomerDetails");
        }
    }
}
