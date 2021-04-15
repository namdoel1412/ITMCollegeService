using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCollegeService.Data.Migrations
{
    public partial class Addsomeprops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "mapApi",
                table: "collegeaddress",
                type: "varchar(1000) CHARACTER SET utf8mb4",
                maxLength: 1000,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "college",
                type: "varchar(500) CHARACTER SET utf8mb4",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "isOnHeader",
                table: "category",
                type: "tinyint unsigned",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mapApi",
                table: "collegeaddress");

            migrationBuilder.DropColumn(
                name: "description",
                table: "college");

            migrationBuilder.DropColumn(
                name: "isOnHeader",
                table: "category");
        }
    }
}
