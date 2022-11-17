using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTourMinsaitVersaoFinal.Migrations
{
    public partial class VIDANOTURNA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VidaNoturnas",
                columns: table => new
                {
                    VidaNoturnaId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    VidaNoturnaNome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VidaNoturnaTipoLocal = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VidaNoturnaHorarioFuncionamento = table.Column<double>(type: "double", nullable: false),
                    VidaNoturnaValorDaEntrada = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VidaNoturnas", x => x.VidaNoturnaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VidaNoturnas");
        }
    }
}
