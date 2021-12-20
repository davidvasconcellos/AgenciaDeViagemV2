using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalViagem.Migrations
{
    public partial class SecundMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Viagens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Origem = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    DataVolta = table.Column<DateTime>(type: "date", nullable: false),
                    DataPartida = table.Column<DateTime>(type: "date", nullable: false),
                    Valor = table.Column<string>(type: "char(50)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viagens", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viagens");
        }
    }
}
