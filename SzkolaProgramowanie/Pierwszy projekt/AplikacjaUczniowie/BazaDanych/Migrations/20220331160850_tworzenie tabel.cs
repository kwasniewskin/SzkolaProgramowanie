using Microsoft.EntityFrameworkCore.Migrations;

namespace AplikacjaUczniowie.BazaDanych.Migrations
{
    public partial class tworzenietabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klasa",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klasa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uczen",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Imie = table.Column<string>(nullable: true),
                    Nazwisko = table.Column<string>(nullable: true),
                    KlasaId = table.Column<int>(nullable: false),
                    Rok_urodzenia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uczen", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Uczen_Klasa_KlasaId",
                        column: x => x.KlasaId,
                        principalTable: "Klasa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Uczen_KlasaId",
                table: "Uczen",
                column: "KlasaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Uczen");

            migrationBuilder.DropTable(
                name: "Klasa");
        }
    }
}
