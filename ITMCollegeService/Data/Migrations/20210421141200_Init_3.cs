using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCollegeService.Data.Migrations
{
    public partial class Init_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKcategory_n779857",
                table: "category_news");

            migrationBuilder.DropForeignKey(
                name: "FKcategory_n984463",
                table: "category_news");

            migrationBuilder.AddForeignKey(
                name: "FKcategory_n779857",
                table: "category_news",
                column: "news_id",
                principalTable: "news",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FKcategory_n984463",
                table: "category_news",
                column: "category_id",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FKcategory_n779857",
                table: "category_news");

            migrationBuilder.DropForeignKey(
                name: "FKcategory_n984463",
                table: "category_news");

            migrationBuilder.AddForeignKey(
                name: "FKcategory_n779857",
                table: "category_news",
                column: "news_id",
                principalTable: "news",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FKcategory_n984463",
                table: "category_news",
                column: "category_id",
                principalTable: "category",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
