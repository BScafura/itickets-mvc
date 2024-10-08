using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class addIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 25, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3744), new DateTime(2024, 5, 5, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3684) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 18, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3752), new DateTime(2024, 5, 15, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3751) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 22, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3757), new DateTime(2024, 5, 15, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3755) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 10, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3761), new DateTime(2024, 5, 5, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3760) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 13, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3765), new DateTime(2024, 5, 5, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3763) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 4, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3769), new DateTime(2024, 5, 18, 0, 17, 10, 505, DateTimeKind.Local).AddTicks(3767) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9440), new DateTime(2024, 5, 4, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 17, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9448), new DateTime(2024, 5, 14, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9447) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 21, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9453), new DateTime(2024, 5, 14, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9451) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9457), new DateTime(2024, 5, 4, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 12, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9461), new DateTime(2024, 5, 4, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9459) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 3, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9465), new DateTime(2024, 5, 17, 23, 34, 13, 326, DateTimeKind.Local).AddTicks(9463) });
        }
    }
}
