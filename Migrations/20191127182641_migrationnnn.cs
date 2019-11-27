using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MertKaymaz_HW5.Migrations
{
    public partial class migrationnnn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    Password = table.Column<string>(maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CetUsers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CetUsers",
                columns: new[] { "Id", "CreatedDate", "Name", "Password", "Surname", "UserName", "role" },
                values: new object[] { 1, new DateTime(2019, 11, 27, 21, 26, 41, 288, DateTimeKind.Local).AddTicks(476), "Super", "8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918", "User", "admin", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CetRoles");

            migrationBuilder.DropTable(
                name: "CetUsers");
        }
    }
}
