using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShortUrlsWebApp.Migrations
{
    public partial class AddedIndexAndReadmeUpdt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ShortUrl",
                table: "Url",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "Index_Url",
                table: "Url",
                column: "ShortUrl",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "GivenUrl" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "Index_Url",
                table: "Url");

            migrationBuilder.AlterColumn<string>(
                name: "ShortUrl",
                table: "Url",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
