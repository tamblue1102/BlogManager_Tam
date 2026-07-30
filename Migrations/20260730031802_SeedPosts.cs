using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogManager_Tam.Migrations
{
    /// <inheritdoc />
    public partial class SeedPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Author", "Content", "IsPublished", "PublishedAt", "Title", "ViewCount" },
                values: new object[,]
                {
                    { 1, "Tâm", "Bài viết giới thiệu các kiến thức nền tảng về ngôn ngữ C#.", true, new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "C# cơ bản", 250 },
                    { 2, "Hải", "Bài viết hướng dẫn cách tổ chức một ứng dụng theo mô hình MVC.", false, new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "MVC nhập môn", 150 },
                    { 3, "Hoàng", "Bài viết tổng quan về Entity Framework Core và cách thao tác dữ liệu.", true, new DateTime(2026, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "EF Core", 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
