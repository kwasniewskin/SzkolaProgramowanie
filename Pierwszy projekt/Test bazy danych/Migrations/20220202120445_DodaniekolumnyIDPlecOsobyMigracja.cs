using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_bazy_danych.Migrations
{
    public partial class DodaniekolumnyIDPlecOsobyMigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlecId",
                table: "Osoby",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlecId",
                table: "Osoby");
        }
    }
}
