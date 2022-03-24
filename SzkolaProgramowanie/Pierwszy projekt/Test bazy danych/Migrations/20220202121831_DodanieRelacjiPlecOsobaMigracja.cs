using Microsoft.EntityFrameworkCore.Migrations;

namespace Test_bazy_danych.Migrations
{
    public partial class DodanieRelacjiPlecOsobaMigracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Osoby_PlecId",
                table: "Osoby",
                column: "PlecId");

            migrationBuilder.AddForeignKey(
                name: "FK_Osoby_Plec_PlecId",
                table: "Osoby",
                column: "PlecId",
                principalTable: "Plec",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Osoby_Plec_PlecId",
                table: "Osoby");

            migrationBuilder.DropIndex(
                name: "IX_Osoby_PlecId",
                table: "Osoby");
        }
    }
}
