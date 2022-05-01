using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingSizeApi.Migrations
{
    public partial class TestMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "ClothingType", "Gender", "L", "M", "Name", "S", "XL", "XS", "XXL", "XXS", "XXXL", "XXXS", "XXXXL" },
                values: new object[] { 1, "top", "female", "12", "6", "Gap", "2", "16", "0", "18", "0", "20", "00", "24" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "ClothingType", "Gender", "L", "M", "Name", "S", "XL", "XS", "XXL", "XXS", "XXXL", "XXXS", "XXXXL" },
                values: new object[] { 2, "bottom", "male", "36R", "34R", "H&M", "32R", "44R", "26R", "46R", "n/a", " 48R", "n/a", "50R" });
        }
    }
}
