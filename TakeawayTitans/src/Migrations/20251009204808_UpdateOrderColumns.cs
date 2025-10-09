using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrderColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CanceledAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PreparingAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReadyAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReceivedAt",
                table: "Orders",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "CanceledAt", "CompletedAt", "PreparingAt", "ReadyAt", "ReceivedAt" },
                values: new object[] { null, null, null, null, new DateTime(2025, 10, 3, 10, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "CanceledAt", "CompletedAt", "PreparingAt", "ReadyAt", "ReceivedAt" },
                values: new object[] { null, null, new DateTime(2025, 10, 1, 15, 30, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 10, 1, 15, 15, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "CanceledAt", "CompletedAt", "PreparingAt", "ReadyAt", "ReceivedAt" },
                values: new object[] { null, null, new DateTime(2025, 10, 2, 11, 5, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 2, 11, 15, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 2, 11, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "CanceledAt", "CompletedAt", "PreparingAt", "ReadyAt", "ReceivedAt" },
                values: new object[] { null, new DateTime(2025, 10, 3, 11, 30, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 3, 11, 15, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 3, 11, 25, 0, 0, DateTimeKind.Utc), new DateTime(2025, 10, 3, 11, 10, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "CanceledAt", "CompletedAt", "PreparingAt", "ReadyAt", "ReceivedAt" },
                values: new object[] { new DateTime(2025, 10, 3, 12, 45, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 10, 3, 12, 35, 0, 0, DateTimeKind.Utc), null, new DateTime(2025, 10, 3, 12, 30, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 48, 7, 839, DateTimeKind.Utc).AddTicks(120), "$2a$11$xoIM0oqtdW5lkYjc90se3uqcLhPl3iITEeKqHKHISK2W/eKvHd8x6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 48, 7, 839, DateTimeKind.Utc).AddTicks(120), "$2a$11$xoIM0oqtdW5lkYjc90se3uqcLhPl3iITEeKqHKHISK2W/eKvHd8x6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 48, 7, 839, DateTimeKind.Utc).AddTicks(120), "$2a$11$xoIM0oqtdW5lkYjc90se3uqcLhPl3iITEeKqHKHISK2W/eKvHd8x6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 48, 7, 839, DateTimeKind.Utc).AddTicks(130), "$2a$11$xoIM0oqtdW5lkYjc90se3uqcLhPl3iITEeKqHKHISK2W/eKvHd8x6" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 9, 20, 48, 7, 839, DateTimeKind.Utc).AddTicks(130), "$2a$11$xoIM0oqtdW5lkYjc90se3uqcLhPl3iITEeKqHKHISK2W/eKvHd8x6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CanceledAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CompletedAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "PreparingAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReadyAt",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReceivedAt",
                table: "Orders");

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
        }
    }
}
