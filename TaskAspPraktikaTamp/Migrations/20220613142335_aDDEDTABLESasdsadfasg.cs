using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAspPraktikaTamp.Migrations
{
    public partial class aDDEDTABLESasdsadfasg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "Categoryİd",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Cars",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Categoryİd",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
