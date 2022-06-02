﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanTemplate.Migrations
{
    public partial class IsColorFieldDeleteToHomeSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsColor",
                table: "HomeSliders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsColor",
                table: "HomeSliders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
