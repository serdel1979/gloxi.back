using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Users.Back.Migrations
{
    /// <inheritdoc />
    public partial class addroles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0591d981-cd31-4b20-9156-8f15502a4fcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96ed1b0e-0f09-4ced-9764-ff5a12a1e43f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af46701c-2ad1-4446-a6c4-dd3a20754f9a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40abb75a-5c1e-4f7d-b086-200fe45e1d12", null, "SUPERROOT", "SUPERROOT" },
                    { "ad58d2e3-6e2c-4f03-8f89-2475e300a6be", null, "USER", "USER" },
                    { "d7547a8d-a6ce-46e5-a445-411703609737", null, "ROOT", "ROOT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40abb75a-5c1e-4f7d-b086-200fe45e1d12");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad58d2e3-6e2c-4f03-8f89-2475e300a6be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7547a8d-a6ce-46e5-a445-411703609737");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0591d981-cd31-4b20-9156-8f15502a4fcc", null, "USER", "USER" },
                    { "96ed1b0e-0f09-4ced-9764-ff5a12a1e43f", null, "ROOT", "ROOT" },
                    { "af46701c-2ad1-4446-a6c4-dd3a20754f9a", null, "SUPERROOT", "SUPERROOT" }
                });
        }
    }
}
