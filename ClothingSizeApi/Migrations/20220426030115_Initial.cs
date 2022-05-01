using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingSizeApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ClothingType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Gender = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    XXXS = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    XXS = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    XS = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    S = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    M = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    L = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    XL = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    XXL = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    XXXL = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    XXXXL = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "ClothingType", "Gender", "L", "M", "Name", "S", "XL", "XS", "XXL", "XXS", "XXXL", "XXXS", "XXXXL" },
                values: new object[] { 1, "top", "female", "12", "6", "Gap", "2", "16", "0", "18", "0", "20", "00", "24" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "ClothingType", "Gender", "L", "M", "Name", "S", "XL", "XS", "XXL", "XXS", "XXXL", "XXXS", "XXXXL" },
                values: new object[] { 2, "bottom", "male", "36R", "34R", "H&M", "32R", "44R", "26R", "46R", "n/a", " 48R", "n/a", "50R" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
