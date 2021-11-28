using Microsoft.EntityFrameworkCore.Migrations;

namespace KhamsaCourseProject.Migrations
{
    public partial class droprelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checks_Payments_PaymentId1",
                table: "Checks");

            migrationBuilder.DropIndex(
                name: "IX_Checks_PaymentId1",
                table: "Checks");

            migrationBuilder.DropColumn(
                name: "PaymentId1",
                table: "Checks");

            migrationBuilder.AlterColumn<long>(
                name: "PaymentId",
                table: "Checks",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PaymentId",
                table: "Checks",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "PaymentId1",
                table: "Checks",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Checks_PaymentId1",
                table: "Checks",
                column: "PaymentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Checks_Payments_PaymentId1",
                table: "Checks",
                column: "PaymentId1",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
