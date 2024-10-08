using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class AdminUser123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9ea39dcf-d3d2-4712-9070-c3d1091eb6f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf09887c-1384-4080-93f8-9daa090b5fae");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "279284e6-8fe5-47fc-b689-10af908d436c", null, "Admin", "ADMIN" },
                    { "3cc2f5c1-11fb-471d-9507-81c40fb1b156", null, "User1", "USER1" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8788), new DateTime(2024, 5, 5, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8795), new DateTime(2024, 5, 15, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8794) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8839), new DateTime(2024, 5, 15, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8837) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8843), new DateTime(2024, 5, 5, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8842) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8848), new DateTime(2024, 5, 5, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8846) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8852), new DateTime(2024, 5, 18, 0, 58, 31, 31, DateTimeKind.Local).AddTicks(8850) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "279284e6-8fe5-47fc-b689-10af908d436c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3cc2f5c1-11fb-471d-9507-81c40fb1b156");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9ea39dcf-d3d2-4712-9070-c3d1091eb6f9", null, "Admin", "ADMIN" },
                    { "bf09887c-1384-4080-93f8-9daa090b5fae", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4964), new DateTime(2024, 5, 5, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4859) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4980), new DateTime(2024, 5, 15, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4978) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4984), new DateTime(2024, 5, 15, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4983) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4989), new DateTime(2024, 5, 5, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4987) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4993), new DateTime(2024, 5, 5, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4991) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4997), new DateTime(2024, 5, 18, 0, 54, 31, 2, DateTimeKind.Local).AddTicks(4995) });
        }
    }
}
