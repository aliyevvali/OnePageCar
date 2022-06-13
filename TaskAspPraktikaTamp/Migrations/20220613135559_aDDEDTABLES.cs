using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskAspPraktikaTamp.Migrations
{
    public partial class aDDEDTABLES : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(nullable: true),
                    DoorCout = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    RentACar = table.Column<bool>(nullable: false),
                    Luggage = table.Column<int>(nullable: false),
                    Transmission = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    AirConditioning = table.Column<bool>(nullable: false),
                    MinimumAge = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: true),
                    Categoryİd = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
