using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Mudanlasadadsda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e9b5713-5496-4489-bad2-e4dbb5ccf5fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "984ca3cf-0451-42ad-9bd3-d79618755eb0");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "689ed564-d7cf-44e6-ba79-c0d1ea6008c9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e7e1c17a-4426-444c-9718-f281cfdc7473");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2e9b5713-5496-4489-bad2-e4dbb5ccf5fa", null, "User1", "USER1" },
                    { "984ca3cf-0451-42ad-9bd3-d79618755eb0", null, "Admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2097), new DateTime(2024, 5, 5, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2104), new DateTime(2024, 5, 15, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2108), new DateTime(2024, 5, 15, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2112), new DateTime(2024, 5, 5, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2116), new DateTime(2024, 5, 5, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2120), new DateTime(2024, 5, 18, 21, 32, 18, 168, DateTimeKind.Local).AddTicks(2119) });
        }
    }
}
