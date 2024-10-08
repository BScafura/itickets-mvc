using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class MaisUmaMigration1231238766 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 8, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3793), new DateTime(2024, 4, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3733) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 1, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3803), new DateTime(2024, 4, 28, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3802) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 5, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3808), new DateTime(2024, 4, 28, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3806) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 23, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3812), new DateTime(2024, 4, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3811) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 26, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3816), new DateTime(2024, 4, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3821), new DateTime(2024, 5, 1, 4, 7, 40, 62, DateTimeKind.Local).AddTicks(3819) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
