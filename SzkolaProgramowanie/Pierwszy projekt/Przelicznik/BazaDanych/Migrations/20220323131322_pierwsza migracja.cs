using Microsoft.EntityFrameworkCore.Migrations;

namespace Przelicznik.BazaDanych.Migrations
{
    public partial class pierwszamigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rodzaj",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rodzaj", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jednostki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(nullable: true),
                    Symbol = table.Column<string>(nullable: true),
                    RodzajId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jednostki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jednostki_Rodzaj_RodzajId",
                        column: x => x.RodzajId,
                        principalTable: "Rodzaj",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Przeliczniki",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    JednostkaZrodlowaId = table.Column<int>(nullable: false),
                    JednostkaDocelowaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Przeliczniki", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Przeliczniki_Jednostki_JednostkaDocelowaId",
                        column: x => x.JednostkaDocelowaId,
                        principalTable: "Jednostki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Przeliczniki_Jednostki_JednostkaZrodlowaId",
                        column: x => x.JednostkaZrodlowaId,
                        principalTable: "Jednostki",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jednostki_RodzajId",
                table: "Jednostki",
                column: "RodzajId");

            migrationBuilder.CreateIndex(
                name: "IX_Przeliczniki_JednostkaDocelowaId",
                table: "Przeliczniki",
                column: "JednostkaDocelowaId");

            migrationBuilder.CreateIndex(
                name: "IX_Przeliczniki_JednostkaZrodlowaId",
                table: "Przeliczniki",
                column: "JednostkaZrodlowaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Przeliczniki");

            migrationBuilder.DropTable(
                name: "Jednostki");

            migrationBuilder.DropTable(
                name: "Rodzaj");
        }
    }
}
