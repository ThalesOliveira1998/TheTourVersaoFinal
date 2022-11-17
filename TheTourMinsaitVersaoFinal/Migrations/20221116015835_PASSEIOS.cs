using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTourMinsaitVersaoFinal.Migrations
{
    public partial class PASSEIOS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Passeios",
                columns: table => new
                {
                    PasseioId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    PasseioNome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasseioGuia = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PasseioDescricao = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    QuantidadeDePessoas = table.Column<int>(type: "int", nullable: false),
                    ValorCobradoPasseio = table.Column<double>(type: "double", nullable: false),
                    GuiaFalaIngles = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passeios", x => x.PasseioId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Passeios");
        }
    }
}
