using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PairProgrammingDatabasesCustomersAndOrders.Migrations
{
    /// <inheritdoc />
    public partial class AddTableSchemaandColumntoclassCustomer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "people");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customers",
                newSchema: "people");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "people",
                table: "Customers",
                newName: "CustomerFullName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Customers",
                schema: "people",
                newName: "Customers");

            migrationBuilder.RenameColumn(
                name: "CustomerFullName",
                table: "Customers",
                newName: "Name");
        }
    }
}
