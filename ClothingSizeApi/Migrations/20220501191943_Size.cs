using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingSizeApi.Migrations
{
    public partial class Size : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ClothingType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    LetterSize = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Neck = table.Column<double>(type: "double", nullable: false),
                    Chest = table.Column<int>(type: "int", nullable: false),
                    Sleeve = table.Column<int>(type: "int", nullable: false),
                    Waist = table.Column<int>(type: "int", nullable: false),
                    Hip = table.Column<int>(type: "int", nullable: false),
                    Inseam = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.SizeId);
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "SizeId", "Chest", "ClothingType", "Gender", "Hip", "Inseam", "LetterSize", "Neck", "Sleeve", "Waist" },
                values: new object[,]
                {
                    { 1, 38, "top", "female", 30, 31, "s", 15.0, 32, 32 },
                    { 2, 38, "top", "male", 30, 31, "s", 16.0, 32, 32 },
                    { 3, 38, "bottom", "female", 30, 31, "s", 15.5, 32, 32 },
                    { 4, 40, "bottom", "male", 30, 32, "m", 16.0, 33, 34 },
                    { 5, 40, "top", "male", 30, 32, "m", 16.5, 33, 34 },
                    { 6, 40, "top", "male", 30, 32, "m", 16.0, 33, 34 },
                    { 7, 42, "bottom", "female", 30, 34, "l", 16.5, 34, 36 },
                    { 8, 42, "bottom", "female", 30, 34, "l", 17.0, 34, 36 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
