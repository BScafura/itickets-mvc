using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class passwordproblem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689ed564-d7cf-44e6-ba79-c0d1ea6008c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7e1c17a-4426-444c-9718-f281cfdc7473");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d113f90-83ba-40b7-940c-7a9c1c3d858d", null, "User", "USER" },
                    { "4da02a5b-1c0a-4554-bc11-dc9eb6e4db46", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8708), new DateTime(2024, 5, 5, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8652) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8715), new DateTime(2024, 5, 15, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8720), new DateTime(2024, 5, 15, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8718) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8724), new DateTime(2024, 5, 5, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8723) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8728), new DateTime(2024, 5, 5, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8727) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8732), new DateTime(2024, 5, 18, 23, 12, 30, 504, DateTimeKind.Local).AddTicks(8731) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d113f90-83ba-40b7-940c-7a9c1c3d858d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4da02a5b-1c0a-4554-bc11-dc9eb6e4db46");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "689ed564-d7cf-44e6-ba79-c0d1ea6008c9", null, "Admin", "ADMIN" },
                    { "e7e1c17a-4426-444c-9718-f281cfdc7473", null, "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7110), new DateTime(2024, 5, 5, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7121), new DateTime(2024, 5, 15, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7125), new DateTime(2024, 5, 15, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7130), new DateTime(2024, 5, 5, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7134), new DateTime(2024, 5, 5, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7138), new DateTime(2024, 5, 18, 21, 53, 32, 726, DateTimeKind.Local).AddTicks(7136) });
        }
    }
}
