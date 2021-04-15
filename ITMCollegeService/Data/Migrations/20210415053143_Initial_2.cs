using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITMCollegeService.Data.Migrations
{
    public partial class Initial_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CollegeaddressId",
                table: "student",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<byte>(
                name: "isBanner",
                table: "news",
                type: "tinyint unsigned",
                nullable: false,
                defaultValueSql: "((0))");

            migrationBuilder.AddColumn<byte>(
                name: "status",
                table: "news",
                type: "tinyint unsigned",
                nullable: false,
                defaultValueSql: "((1))");

            migrationBuilder.CreateTable(
                name: "college",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: false),
                    icon = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true),
                    logo = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_college", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "collegeaddress",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(type: "varchar(500) CHARACTER SET utf8mb4", maxLength: 500, nullable: false),
                    phone = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true),
                    email = table.Column<string>(type: "varchar(100) CHARACTER SET utf8mb4", maxLength: 100, nullable: true),
                    isMainFacility = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    college_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collegeaddress", x => x.id);
                    table.ForeignKey(
                        name: "collegeaddress_ibfk_1",
                        column: x => x.college_id,
                        principalTable: "college",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_student_CollegeaddressId",
                table: "student",
                column: "CollegeaddressId");

            migrationBuilder.CreateIndex(
                name: "college_id",
                table: "collegeaddress",
                column: "college_id");

            migrationBuilder.AddForeignKey(
                name: "FK_student_collegeaddress_CollegeaddressId",
                table: "student",
                column: "CollegeaddressId",
                principalTable: "collegeaddress",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_student_collegeaddress_CollegeaddressId",
                table: "student");

            migrationBuilder.DropTable(
                name: "collegeaddress");

            migrationBuilder.DropTable(
                name: "college");

            migrationBuilder.DropIndex(
                name: "IX_student_CollegeaddressId",
                table: "student");

            migrationBuilder.DropColumn(
                name: "CollegeaddressId",
                table: "student");

            migrationBuilder.DropColumn(
                name: "isBanner",
                table: "news");

            migrationBuilder.DropColumn(
                name: "status",
                table: "news");
        }
    }
}
