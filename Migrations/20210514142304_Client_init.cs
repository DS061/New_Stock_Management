using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace New_Stock_Management.Migrations
{
    public partial class Client_init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client_Master",
                columns: table => new
                {
                    Client_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Client_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Client_Edate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client_Master", x => x.Client_ID);
                });
            var sqlFile = Path.Combine(".\\Script", @"Script.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client_Master");
        }
    }
}
