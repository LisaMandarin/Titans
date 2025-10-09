using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TakeawayTitans.Migrations
{
    /// <inheritdoc />
    public partial class UpdateMenuItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/8251537/pexels-photo-8251537.jpeg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.cookipedia.co.uk/wiki/images/8/87/Greek_salad_recipe.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQmzYDNf1qIDSjvZLHCi98piiao6gi6K7ZIyw&s");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/c/c4/Salad_with_strawberries.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://images.stockcake.com/public/6/f/6/6f6293cf-b710-40e3-b0c6-af329f49c182/hearty-cobb-salad-stockcake.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.pexels.com/photos/8169597/pexels-photo-8169597.jpeg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQEg03LIorRnJYimTc6rQ0rLUd_B9RrKp0GnA&s");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.rawpixel.com/image_social_landscape/czNmcy1wcml2YXRlL3Jhd3BpeGVsX2ltYWdlcy93ZWJzaXRlX2NvbnRlbnQvbHIvaXMxMTA0NS1pbWFnZS1rd3lzaTYwZC5qcGc.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://i1.pickpik.com/photos/153/22/476/green-smoothie-drink-healthy-preview.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://i1.pickpik.com/photos/585/986/375/smoothie-milkshake-mixed-berry-preview.jpg");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://example.com/caesar-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://example.com/greek-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://example.com/garden-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://example.com/spinach-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://example.com/cobb-salad.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://example.com/strawberry-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://example.com/mango-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://example.com/banana-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://example.com/green-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "ImageUrl",
                value: "https://example.com/berry-blast-smoothie.jpg");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 3, 4, 28, 47, 252, DateTimeKind.Utc).AddTicks(8160), "$2a$11$QYa1hVfrQZqG6p84ErmlIOzjgBRr8D.Y1OmGzPCQGpOZB6au55e3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 3, 4, 28, 47, 252, DateTimeKind.Utc).AddTicks(8170), "$2a$11$QYa1hVfrQZqG6p84ErmlIOzjgBRr8D.Y1OmGzPCQGpOZB6au55e3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 3, 4, 28, 47, 252, DateTimeKind.Utc).AddTicks(8200), "$2a$11$QYa1hVfrQZqG6p84ErmlIOzjgBRr8D.Y1OmGzPCQGpOZB6au55e3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 3, 4, 28, 47, 252, DateTimeKind.Utc).AddTicks(8220), "$2a$11$QYa1hVfrQZqG6p84ErmlIOzjgBRr8D.Y1OmGzPCQGpOZB6au55e3e" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "PasswordHash" },
                values: new object[] { new DateTime(2025, 10, 3, 4, 28, 47, 252, DateTimeKind.Utc).AddTicks(8230), "$2a$11$QYa1hVfrQZqG6p84ErmlIOzjgBRr8D.Y1OmGzPCQGpOZB6au55e3e" });
        }
    }
}
