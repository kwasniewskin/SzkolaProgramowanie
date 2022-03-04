using Microsoft.EntityFrameworkCore.Migrations;

namespace Baza_danych.Migrations
{
    public partial class PierwszaMigracjaQuizDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pytania",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrescPytania = table.Column<string>(maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pytania", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Odpowiedzi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrescOdpowiedzi = table.Column<string>(maxLength: 200, nullable: false),
                    CzyPoprawna = table.Column<bool>(nullable: false),
                    PytanieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odpowiedzi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Odpowiedzi_Pytania_PytanieId",
                        column: x => x.PytanieId,
                        principalTable: "Pytania",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Odpowiedzi_PytanieId",
                table: "Odpowiedzi",
                column: "PytanieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odpowiedzi");

            migrationBuilder.DropTable(
                name: "Pytania");
        }
    }
}
