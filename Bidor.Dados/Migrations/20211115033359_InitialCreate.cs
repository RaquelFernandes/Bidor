using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bidor.Dados.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aluno",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DataDeNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aluno", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Materia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ativo = table.Column<bool>(type: "bit", nullable: false),
                    DataDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDeAtividade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDeAtividade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Turma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ano = table.Column<short>(type: "smallint", nullable: false),
                    Semestre = table.Column<short>(type: "smallint", nullable: false),
                    DataDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MateriaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turma", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Turma_Materia_MateriaId",
                        column: x => x.MateriaId,
                        principalTable: "Materia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Atividade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoId = table.Column<int>(type: "int", nullable: true),
                    TipoDeAtividadeId = table.Column<int>(type: "int", nullable: true),
                    DataDeRegistro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataDaAtividade = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PontosObtidos = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividade_Aluno_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Aluno",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atividade_TipoDeAtividade_TipoDeAtividadeId",
                        column: x => x.TipoDeAtividadeId,
                        principalTable: "TipoDeAtividade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_AlunoId",
                table: "Atividade",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividade_TipoDeAtividadeId",
                table: "Atividade",
                column: "TipoDeAtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Turma_MateriaId",
                table: "Turma",
                column: "MateriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Atividade");

            migrationBuilder.DropTable(
                name: "Turma");

            migrationBuilder.DropTable(
                name: "Aluno");

            migrationBuilder.DropTable(
                name: "TipoDeAtividade");

            migrationBuilder.DropTable(
                name: "Materia");
        }
    }
}
