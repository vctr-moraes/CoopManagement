using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoopManagement.Data.Migrations
{
    public partial class Tabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Grau = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cooperados",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CursoId = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 100, nullable: false),
                    Sexo = table.Column<int>(nullable: false),
                    EstadoCivil = table.Column<int>(nullable: false),
                    DataNascimento = table.Column<DateTime>(nullable: false),
                    RacaCor = table.Column<int>(nullable: false),
                    NecessidadeEspecial = table.Column<int>(nullable: false),
                    Cpf = table.Column<string>(maxLength: 11, nullable: false),
                    Rg = table.Column<string>(nullable: true),
                    OrgaoExpedidorRg = table.Column<string>(nullable: true),
                    DataExpedicaoRg = table.Column<DateTime>(nullable: true),
                    Naturalidade = table.Column<string>(maxLength: 50, nullable: false),
                    Nacionalidade = table.Column<string>(maxLength: 50, nullable: false),
                    NomePai = table.Column<string>(maxLength: 100, nullable: false),
                    NomeMae = table.Column<string>(maxLength: 100, nullable: false),
                    RendaFamiliar = table.Column<string>(nullable: true),
                    Matricula = table.Column<string>(maxLength: 20, nullable: false),
                    Turma = table.Column<string>(nullable: false),
                    Escolaridade = table.Column<int>(nullable: false),
                    Logradouro = table.Column<string>(maxLength: 150, nullable: false),
                    Bairro = table.Column<string>(maxLength: 100, nullable: false),
                    Cidade = table.Column<string>(maxLength: 100, nullable: false),
                    Cep = table.Column<string>(maxLength: 8, nullable: false),
                    Estado = table.Column<string>(maxLength: 50, nullable: false),
                    TelefoneResidencial = table.Column<string>(nullable: true),
                    TelefoneCelular = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(maxLength: 100, nullable: false),
                    DataMatricula = table.Column<DateTime>(nullable: false),
                    DataDesligamento = table.Column<DateTime>(nullable: true),
                    CotaParte = table.Column<decimal>(nullable: false),
                    StatusMatricula = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cooperados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cooperados_Cursos_CursoId",
                        column: x => x.CursoId,
                        principalTable: "Cursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cooperados_CursoId",
                table: "Cooperados",
                column: "CursoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cooperados");

            migrationBuilder.DropTable(
                name: "Cursos");
        }
    }
}
