using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhamsaCourseProject.Migrations
{
    public partial class sectortable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentLessonSectorId",
                table: "Students",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StudentLessonSectors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentLessonSectors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_StudentLessonSectorId",
                table: "Students",
                column: "StudentLessonSectorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentLessonSectors_StudentLessonSectorId",
                table: "Students",
                column: "StudentLessonSectorId",
                principalTable: "StudentLessonSectors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentLessonSectors_StudentLessonSectorId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "StudentLessonSectors");

            migrationBuilder.DropIndex(
                name: "IX_Students_StudentLessonSectorId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentLessonSectorId",
                table: "Students");
        }
    }
}
