using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTourMinsaitVersaoFinal.Migrations
{
    public partial class PONTOSTURISTICOSbairros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PontosTuristicos_Bairros_BairroId",
                table: "PontosTuristicos");

            migrationBuilder.DropIndex(
                name: "IX_PontosTuristicos_BairroId",
                table: "PontosTuristicos");

            migrationBuilder.DropColumn(
                name: "BairroId",
                table: "PontosTuristicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BairroId",
                table: "PontosTuristicos",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                collation: "ascii_general_ci");

            migrationBuilder.CreateIndex(
                name: "IX_PontosTuristicos_BairroId",
                table: "PontosTuristicos",
                column: "BairroId");

            migrationBuilder.AddForeignKey(
                name: "FK_PontosTuristicos_Bairros_BairroId",
                table: "PontosTuristicos",
                column: "BairroId",
                principalTable: "Bairros",
                principalColumn: "BairroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
