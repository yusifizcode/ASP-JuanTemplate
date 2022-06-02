using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanTemplate.Migrations
{
    public partial class IsColorFieldAddToHomeSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsColor",
                table: "HomeSliders",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsColor",
                table: "HomeSliders");
        }
    }
}
