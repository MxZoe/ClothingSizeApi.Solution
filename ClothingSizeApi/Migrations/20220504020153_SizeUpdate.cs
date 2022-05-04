using Microsoft.EntityFrameworkCore.Migrations;

namespace ClothingSizeApi.Migrations
{
    public partial class SizeUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Brand",
                table: "Sizes",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "Gender",
                value: "mens");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "Gender",
                value: "mens");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "Gender",
                value: "mens");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 4,
                column: "Gender",
                value: "mens");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5,
                column: "Gender",
                value: "mens");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 6,
                column: "Gender",
                value: "mens");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 7,
                column: "Gender",
                value: "womens");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 8,
                column: "Gender",
                value: "womens");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 1,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "Gap", "womens" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 2,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "H&M", "mens" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 3,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "Gap", "womens" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 4,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "H&M", "mens" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 5,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "Gap", "mens" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "H&M", "mens" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 7,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "Gap", "womens" });

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 8,
                columns: new[] { "Brand", "Gender" },
                values: new object[] { "H&M", "womens" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Brand",
                table: "Sizes");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 1,
                column: "Gender",
                value: "female");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 2,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 3,
                column: "Gender",
                value: "female");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 4,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 5,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 6,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 7,
                column: "Gender",
                value: "female");

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "BrandId",
                keyValue: 8,
                column: "Gender",
                value: "female");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 1,
                column: "Gender",
                value: "female");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 2,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 3,
                column: "Gender",
                value: "female");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 4,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 5,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 6,
                column: "Gender",
                value: "male");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 7,
                column: "Gender",
                value: "female");

            migrationBuilder.UpdateData(
                table: "Sizes",
                keyColumn: "SizeId",
                keyValue: 8,
                column: "Gender",
                value: "female");
        }
    }
}
