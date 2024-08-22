using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProductsCatalogService.API.Migrations
{
    /// <inheritdoc />
    public partial class dataseed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "Category", "Country", "Description", "IsAvailable", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "TechBrand", "Electronics", "USA", "Latest model with high-resolution camera and fast processor", true, "Smartphone X1", 799 },
                    { 2, "ComputeTech", "Computers", "Germany", "Powerful laptop with 16GB RAM and 512GB SSD", true, "Laptop Pro 15", 1299 },
                    { 3, "SoundGear", "Accessories", "Japan", "Noise-cancelling over-ear headphones with long battery life", false, "Wireless Headphones", 199 },
                    { 4, "ViewMax", "Electronics", "South Korea", "Ultra HD 4K Smart TV with built-in streaming apps", true, "Smart TV 55\"", 499 },
                    { 5, "SportX", "Sportswear", "India", "Comfortable and durable running shoes with excellent grip", true, "Running Shoes", 120 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}
