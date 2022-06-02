using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanTemplate.Migrations
{
    public partial class ColorFieldTypeChangedToHomeFeatures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsColor",
                table: "HomeFeatures");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "HomeFeatures",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "HomeFeatures");

            migrationBuilder.AddColumn<string>(
                name: "IsColor",
                table: "HomeFeatures",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
