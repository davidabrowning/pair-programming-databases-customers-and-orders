using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PairProgrammingDatabasesCustomersAndOrders.Migrations
{
    /// <inheritdoc />
    public partial class Updateclassesfromusingidstousingobjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descriptions",
                table: "Products",
                newName: "Description");

            migrationBuilder.CreateIndex(
                name: "IX_OrderRows_ProductId",
                table: "OrderRows",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderRows_Products_ProductId",
                table: "OrderRows",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderRows_Products_ProductId",
                table: "OrderRows");

            migrationBuilder.DropIndex(
                name: "IX_OrderRows_ProductId",
                table: "OrderRows");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Descriptions");
        }
    }
}
