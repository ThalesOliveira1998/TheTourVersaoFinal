using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheTourMinsaitVersaoFinal.Migrations
{
    public partial class ID9b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bairros",
                columns: table => new
                {
                    BairroId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    BairroNome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bairros", x => x.BairroId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bairros");
        }
    }
}
