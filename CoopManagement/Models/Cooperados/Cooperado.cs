using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CoopManagement.Models.Cooperados;
using CoopManagement.Models.Cursos;

namespace CoopManagement.Models.Cooperados
{
    public class Cooperado : Entidade
    {
        public Guid CursoId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Sexo Sexo { get; set; }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public EstadoCivil EstadoCivil { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Raça/Cor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public RacaCor RacaCor { get; set; }

        [Display(Name = "Necessidades Especiais")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public NecessidadeEspecial NecessidadeEspecial { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter {1} caracteres.", MinimumLength = 11)]
        public string Cpf { get; set; }

        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Display(Name = "Órgão Expedidor")]
        public string OrgaoExpedidorRg { get; set; }

        [Display(Name = "Data de Expedição")]
        public DateTime DataExpedicaoRg { get; set; }

        [Display(Name = "Naturalidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Naturalidade { get; set; }

        [Display(Name = "Nacionalidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Nacionalidade { get; set; }

        [Display(Name = "Nome do Pai")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string NomePai { get; set; }

        [Display(Name = "Nome da Mãe")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string NomeMae { get; set; }

        [Display(Name = "Renda Familiar")]
        public string RendaFamiliar { get; set; }

        [Display(Name = "Matrícula")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(20, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Matricula { get; set; }

        [Display(Name = "Turma")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Turma { get; set; }

        [Display(Name = "Escolaridade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Escolaridade Escolaridade { get; set; }

        [Display(Name = "Logradouro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(150, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Logradouro { get; set; }

        [Display(Name = "Bairro")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Cidade { get; set; }

        [Display(Name = "CEP")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter {1} caracteres.", MinimumLength = 8)]
        public string Cep { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Estado { get; set; }

        [Display(Name = "Telefone Residencial")]
        public string TelefoneResidencial { get; set; }

        [Display(Name = "Telefone Celular")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter {1} caracteres.", MinimumLength = 11)]
        public string TelefoneCelular { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Email { get; set; }

        [Display(Name = "Data de Matrícula")]
        public DateTime DataMatricula { get; set; }

        [Display(Name = "Data de Desligamento")]
        public DateTime DataDesligamento { get; set; }

        [Display(Name = "Cota-parte")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public decimal CotaParte { get; set; }

        [Display(Name = "Status da Matrícula")]
        public StatusMatricula StatusMatricula { get; set; }

        /* EF Relations */
        public Curso Curso { get; set; }
    }
}
