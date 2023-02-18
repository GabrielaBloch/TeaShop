using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeaShop.Migrations
{
    public partial class addOrderStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "orderStatuses",
                columns: new[] { "Id", "StatusId", "StatusName" },
                values: new object[] { 1, 1, "Złożone" });

            migrationBuilder.InsertData(
                table: "orderStatuses",
                columns: new[] { "Id", "StatusId", "StatusName" },
                values: new object[] { 2, 2, "W trakcie" });

            migrationBuilder.InsertData(
                table: "orderStatuses",
                columns: new[] { "Id", "StatusId", "StatusName" },
                values: new object[] { 3, 3, "Anulowane" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "orderStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "orderStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "orderStatuses",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
