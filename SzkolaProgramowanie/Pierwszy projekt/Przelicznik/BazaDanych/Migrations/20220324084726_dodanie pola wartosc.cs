using Microsoft.EntityFrameworkCore.Migrations;

namespace Przelicznik.BazaDanych.Migrations
{
    public partial class dodaniepolawartosc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Wartosc",
                table: "Przeliczniki",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wartosc",
                table: "Przeliczniki");
        }
    }
}
