using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogManager_Tam.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryPublicationFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "Categories",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PublishedAt",
                table: "Categories",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsPublished", "PublishedAt" },
                values: new object[] { true, new DateTime(2026, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsPublished", "PublishedAt" },
                values: new object[] { true, new DateTime(2026, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsPublished", "PublishedAt" },
                values: new object[] { false, new DateTime(2026, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsPublished", "PublishedAt" },
                values: new object[] { true, new DateTime(2026, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsPublished", "PublishedAt" },
                values: new object[] { false, new DateTime(2026, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsPublished", "PublishedAt" },
                values: new object[] { true, new DateTime(2026, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "PublishedAt",
                table: "Categories");
        }
    }
}
