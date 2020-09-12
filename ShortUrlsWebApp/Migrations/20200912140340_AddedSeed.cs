using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShortUrlsWebApp.Migrations
{
    public partial class AddedSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Url",
                columns: new[] { "UrlId", "Created", "GivenUrl", "ShortUrl" },
                values: new object[] { 1L, new DateTime(1979, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://docs.microsoft.com/en-gb/ef/core/modeling/data-seeding", "/sdsf34ds6f5dm" });

            migrationBuilder.InsertData(
                table: "Url",
                columns: new[] { "UrlId", "Created", "GivenUrl", "ShortUrl" },
                values: new object[] { 2L, new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://docs.microsoft.com/en-gb/dotnet/csharp/tutorials/working-with-linq", "/sdsf34d66fsd" });

            migrationBuilder.InsertData(
                table: "Url",
                columns: new[] { "UrlId", "Created", "GivenUrl", "ShortUrl" },
                values: new object[] { 3L, new DateTime(1981, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://docs.microsoft.com/en-gb/dotnet/csharp/", "/sdgdgffd66fsd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Url",
                keyColumn: "UrlId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Url",
                keyColumn: "UrlId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Url",
                keyColumn: "UrlId",
                keyValue: 3L);
        }
    }
}
