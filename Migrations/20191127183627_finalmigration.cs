using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MertKaymaz_HW5.Migrations
{
    public partial class finalmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "Surname" },
                values: new object[] { new DateTime(2019, 11, 27, 21, 36, 27, 361, DateTimeKind.Local).AddTicks(3276), "Mert", "Kaymaz" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Name", "Surname" },
                values: new object[] { new DateTime(2019, 11, 27, 21, 26, 41, 288, DateTimeKind.Local).AddTicks(476), "Super", "User" });
        }
    }
}
