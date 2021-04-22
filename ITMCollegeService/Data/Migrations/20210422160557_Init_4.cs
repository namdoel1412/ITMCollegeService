using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCollegeService.Data.Migrations
{
    public partial class Init_4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "contact",
                type: "datetime",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "contact",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "created_at",
                table: "contact");

            migrationBuilder.DropColumn(
                name: "name",
                table: "contact");
        }
    }
}
