﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DigitalViagem.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CPF = table.Column<string>(type: "char(11)", nullable: false),
                    Endereco = table.Column<string>(type: "char(50)", nullable: false),
                    Telefone = table.Column<string>(type: "char(15)", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "date", nullable: false),
                    Situacao = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
