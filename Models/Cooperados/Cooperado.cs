using System;
using CoopManagement.Models.Cursos;

namespace CoopManagement.Models.Cooperados
{
    public class Cooperado : Entity
    {
        public string Nome { get; set; }

        public Sexo Sexo { get; set; }

        public EstadoCivil EstadoCivil { get; set; }

        public DateTime DataNascimento { get; set; }

        public RacaCor RacaCor { get; set; }

        public NecessidadeEspecial NecessidadeEspecial { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string OrgaoExpedidorRg { get; set; }

        public DateTime DataExpedicaoRg { get; set; }

        public string Naturalidade { get; set; }

        public string Nacionalidade { get; set; }

        public string NomePai { get; set; }

        public string NomeMae { get; set; }

        public string RendaFamiliar { get; set; }

        public string Matricula { get; set; }

        public Guid CursoId { get; set; }

        public string Turma { get; set; }

        public Escolaridade Escolaridade { get; set; }

        public string Logradouro { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Cep { get; set; }

        public string Estado { get; set; }

        public string TelefoneResidencial { get; set; }

        public string TelefoneCelular { get; set; }

        public string Email { get; set; }

        public DateTime DataMatricula { get; set; }

        public DateTime DataDesligamento { get; set; }

        public decimal CotaParte { get; set; }

        public StatusMatricula StatusMatricula { get; set; } = StatusMatricula.Aguardando;

        /* EF Relations */
        public Curso Curso { get; set; }
    }
}
