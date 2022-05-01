using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingSizeApi.Migrations
{
    public partial class TestMigration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "ClothingType", "Gender", "L", "M", "Name", "S", "XL", "XS", "XXL", "XXS", "XXXL", "XXXS", "XXXXL" },
                values: new object[,]
                {
                    { 1, "top", "female", "12", "6", "Gap", "2", "16", "0", "18", "0", "20", "00", "24" },
                    { 2, "top", "male", "12", "6", "Gap", "2", "16", "0", "18", "0", "20", "00", "24" },
                    { 3, "bottom", "female", "12", "6", "Gap", "2", "16", "0", "18", "0", "20", "00", "24" },
                    { 4, "bottom", "male", "12", "6", "Gap", "2", "16", "0", "18", "0", "20", "00", "24" },
                    { 5, "top", "male", "36R", "34R", "H&M", "32R", "44R", "26R", "46R", "n/a", " 48R", "n/a", "50R" },
                    { 6, "top", "male", "12", "6", "H&M", "2", "16", "0", "18", "0", "20", "00", "24" },
                    { 7, "bottom", "female", "12", "6", "H&M", "2", "16", "0", "18", "0", "20", "00", "24" },
                    { 8, "bottom", "female", "12", "6", "H&M", "2", "16", "0", "18", "0", "20", "00", "24" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 8);
        }
    }
}
