using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCollegeService.Data.Migrations
{
    public partial class AddFKinAdmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "admin",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_admin_UserId",
                table: "admin",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FKadmin12912",
                table: "admin",
                column: "UserId",
                principalTable: "user",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKadmin12912",
                table: "admin");

            migrationBuilder.DropIndex(
                name: "IX_admin_UserId",
                table: "admin");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "admin");
        }
    }
}
