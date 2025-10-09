using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Received",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhone",
                table: "Orders",
                type: "character varying(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerEmail",
                table: "Orders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "Customization",
                table: "OrderItems",
                type: "character varying(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedAt", "CustomerEmail", "CustomerName", "CustomerPhone" },
                values: new object[] { 1, new DateTime(2025, 10, 3, 10, 0, 0, 0, DateTimeKind.Utc), "morgan.park@example.com", "Morgan Park", "555-0912" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CreatedAt", "CustomerEmail", "CustomerName", "CustomerPhone", "Status" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 10, 1, 15, 30, 0, 0, DateTimeKind.Utc), "jamie.johnson@example.com", "Jamie Johnson", "555-0134", "Preparing" },
                    { 3, new DateTime(2025, 10, 2, 11, 15, 0, 0, DateTimeKind.Utc), "taylor.nguyen@example.com", "Taylor Nguyen", "555-0456", "Ready" },
                    { 4, new DateTime(2025, 10, 3, 11, 30, 0, 0, DateTimeKind.Utc), "riley.santos@example.com", "Riley Santos", "555-0933", "Completed" },
                    { 5, new DateTime(2025, 10, 3, 12, 45, 0, 0, DateTimeKind.Utc), "jordan.lee@example.com", "Jordan Lee", "555-0977", "Canceled" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 29, 37, 421, DateTimeKind.Utc).AddTicks(6060), "$2a$11$sNGQfq9a47kH7XGt5UsTLeshuume3lV7zjCJxoMqXX4.BSXtz1Ryy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 29, 37, 421, DateTimeKind.Utc).AddTicks(6070), "$2a$11$sNGQfq9a47kH7XGt5UsTLeshuume3lV7zjCJxoMqXX4.BSXtz1Ryy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 29, 37, 421, DateTimeKind.Utc).AddTicks(6070), "$2a$11$sNGQfq9a47kH7XGt5UsTLeshuume3lV7zjCJxoMqXX4.BSXtz1Ryy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 29, 37, 421, DateTimeKind.Utc).AddTicks(6070), "$2a$11$sNGQfq9a47kH7XGt5UsTLeshuume3lV7zjCJxoMqXX4.BSXtz1Ryy" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 29, 37, 421, DateTimeKind.Utc).AddTicks(6080), "$2a$11$sNGQfq9a47kH7XGt5UsTLeshuume3lV7zjCJxoMqXX4.BSXtz1Ryy" });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Customization", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, "No croutons", 1, 1, 2 },
                    { 2, "Extra strawberries", 6, 1, 1 },
                    { 3, "Add grilled chicken", 4, 2, 1 },
                    { 4, null, 9, 2, 2 },
                    { 5, "Light dressing", 1, 3, 1 },
                    { 6, null, 9, 3, 2 },
                    { 7, "No onions", 4, 4, 1 },
                    { 8, "Extra strawberries", 6, 4, 1 },
                    { 9, "No croutons", 1, 5, 1 },
                    { 10, "Add grilled chicken", 4, 5, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OrderItems",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Orders",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldDefaultValue: "Received");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerPhone",
                table: "Orders",
                type: "character varying(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(20)",
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerName",
                table: "Orders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerEmail",
                table: "Orders",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Customization",
                table: "OrderItems",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 9, 37, 532, DateTimeKind.Utc).AddTicks(7290), "$2a$11$VunEybTvoIfOz2RgTCT2aurMRwIMmwVwT9bfrftEF7nSm1PMtHCIu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 9, 37, 532, DateTimeKind.Utc).AddTicks(7300), "$2a$11$VunEybTvoIfOz2RgTCT2aurMRwIMmwVwT9bfrftEF7nSm1PMtHCIu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 9, 37, 532, DateTimeKind.Utc).AddTicks(7300), "$2a$11$VunEybTvoIfOz2RgTCT2aurMRwIMmwVwT9bfrftEF7nSm1PMtHCIu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 9, 37, 532, DateTimeKind.Utc).AddTicks(7300), "$2a$11$VunEybTvoIfOz2RgTCT2aurMRwIMmwVwT9bfrftEF7nSm1PMtHCIu" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 9, 37, 532, DateTimeKind.Utc).AddTicks(7310), "$2a$11$VunEybTvoIfOz2RgTCT2aurMRwIMmwVwT9bfrftEF7nSm1PMtHCIu" });
        }
    }
}
