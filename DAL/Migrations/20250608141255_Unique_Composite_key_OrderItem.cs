using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Unique_Composite_key_OrderItem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId_OrderId",
                table: "OrderItem",
                columns: new[] { "ProductId", "OrderId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductId_OrderId",
                table: "OrderItem");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");
        }
    }
}
