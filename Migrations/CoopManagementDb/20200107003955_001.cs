using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoopManagement.Migrations.CoopManagementDb
{
    public partial class _001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Curso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Grau = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cooperado",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(nullable: true),
                    Sexo = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    RacaCor = table.Column<string>(nullable: true),
                    NecessidadeEspecial = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    Rg = table.Column<string>(nullable: true),
                    OrgaoExpedidorRg = table.Column<string>(nullable: true),
                    DataExpedicaoRg = table.Column<DateTime>(nullable: true),
                    Naturalidade = table.Column<string>(nullable: true),
                    Nacionalidade = table.Column<string>(nullable: true),
                    NomePai = table.Column<string>(nullable: true),
                    NomeMae = table.Column<string>(nullable: true),
                    RendaFamiliar = table.Column<double>(nullable: false),
                    Matricula = table.Column<string>(nullable: true),
                    CursoId = table.Column<int>(nullable: true),
                    Turma = table.Column<string>(nullable: true),
                    Escolaridade = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Cep = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    TelefoneResidencial = table.Column<string>(nullable: true),
                    TelefoneCelular = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    DataMatricula = table.Column<DateTime>(nullable: false),
                    DataDesligamento = table.Column<DateTime>(nullable: true),
                    CotaParte = table.Column<double>(nullable: false),
                    StatusMatricula = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cooperado_Curso_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Curso",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cooperado_CursoId",
                table: "Cooperado",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cooperado");

            migrationBuilder.DropTable(
                name: "Curso");
        }
    }
}
