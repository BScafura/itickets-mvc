using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Migrations
{
    /// <inheritdoc />
    public partial class Identityadd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Tordens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Tordens",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome = table.Column<int>(type: "int", nullable: false),
                    MyProperty = table.Column<int>(type: "int", nullable: false),
                    MyProperty1 = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9153), new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 17, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9160), new DateTime(2024, 5, 14, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 21, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9164), new DateTime(2024, 5, 14, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9163) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 9, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9169), new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 12, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9173), new DateTime(2024, 5, 4, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 6, 3, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9177), new DateTime(2024, 5, 17, 21, 35, 11, 326, DateTimeKind.Local).AddTicks(9175) });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Tordens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Tordens",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 14, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8493), new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8433) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 7, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8507), new DateTime(2024, 5, 4, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 11, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8512), new DateTime(2024, 5, 4, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8510) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 4, 29, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8518), new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8516) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 2, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8523), new DateTime(2024, 4, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8521) });

            migrationBuilder.UpdateData(
                table: "Tfilmes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DataFim", "DataInicio" },
                values: new object[] { new DateTime(2024, 5, 24, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8529), new DateTime(2024, 5, 7, 17, 8, 39, 121, DateTimeKind.Local).AddTicks(8527) });
        }
    }
}
