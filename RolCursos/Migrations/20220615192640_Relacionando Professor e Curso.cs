using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RolCursos.Migrations
{
    public partial class RelacionandoProfessoreCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Curso",
                table: "TabelaDeProfessores");

            migrationBuilder.AddColumn<Guid>(
                name: "ProfessorId",
                table: "TabelaDeCursos",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_TabelaDeCursos_ProfessorId",
                table: "TabelaDeCursos",
                column: "ProfessorId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TabelaDeCursos_TabelaDeProfessores_ProfessorId",
                table: "TabelaDeCursos",
                column: "ProfessorId",
                principalTable: "TabelaDeProfessores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TabelaDeCursos_TabelaDeProfessores_ProfessorId",
                table: "TabelaDeCursos");

            migrationBuilder.DropIndex(
                name: "IX_TabelaDeCursos_ProfessorId",
                table: "TabelaDeCursos");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "TabelaDeCursos");

            migrationBuilder.AddColumn<string>(
                name: "Curso",
                table: "TabelaDeProfessores",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
