using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RolCursos.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TabelaDeCursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeDoCurso = table.Column<string>(nullable: false),
                    Duracao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeCursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TabelaDeProfessores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    NomeProfessor = table.Column<string>(nullable: false),
                    Curso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabelaDeProfessores", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TabelaDeCursos");

            migrationBuilder.DropTable(
                name: "TabelaDeProfessores");
        }
    }
}
