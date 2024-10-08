using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class MaisUmaMigration123123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7366), new DateTime(2024, 4, 18, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7307) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7374), new DateTime(2024, 4, 28, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7372) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7378), new DateTime(2024, 4, 28, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7377) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7383), new DateTime(2024, 4, 18, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7382) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7387), new DateTime(2024, 4, 18, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7392), new DateTime(2024, 5, 1, 4, 4, 1, 244, DateTimeKind.Local).AddTicks(7390) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1061), new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1005) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1068), new DateTime(2024, 4, 28, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1073), new DateTime(2024, 4, 28, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1078), new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1076) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1082), new DateTime(2024, 4, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1081) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1087), new DateTime(2024, 5, 1, 4, 3, 15, 336, DateTimeKind.Local).AddTicks(1085) });
        }
    }
}
