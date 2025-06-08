using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Relationship_Updates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_CategoryId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_CategoryId",
                table: "Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CategoryId",
                table: "OrderItem",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_CategoryId",
                table: "Inventory",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Product_CategoryId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_CategoryId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_CategoryId",
                table: "Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CategoryId",
                table: "OrderItem",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_CategoryId",
                table: "Inventory",
                column: "CategoryId",
                unique: true);
        }
    }
}
