using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipsUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Category_CategoryId",
                table: "Inventory");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Category_CategoryId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_CategoryId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Inventory_CategoryId",
                table: "Inventory");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Inventory");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "OrderItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Inventory",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CategoryId",
                table: "OrderItem",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ProductId",
                table: "OrderItem",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inventory_CategoryId",
                table: "Inventory",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Category_CategoryId",
                table: "Inventory",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Category_CategoryId",
                table: "OrderItem",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
