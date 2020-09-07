using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoopManagement.Models.Cursos;

namespace CoopManagement.Models.Cooperados
{
    public class Cooperado : Entidade
    {
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
        [DataType(DataType.Date)]
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
        [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo 11 caracteres.")]
        public string Cpf { get; set; }

        [Display(Name = "RG")]
        [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo 20 caracteres.")]
        public string Rg { get; set; }

        [Display(Name = "Órgão Expedidor")]
        [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo 20 caracteres.")]
        public string OrgaoExpedidorRg { get; set; }

        [Display(Name = "Data de Expedição")]
        [DataType(DataType.Date)]
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
        [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo 20 caracteres.")]
        public string RendaFamiliar { get; set; }

        [Display(Name = "Matrícula Acadêmica")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(20, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Matricula { get; set; }

        [Display(Name = "Curso")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public Guid CursoId { get; set; }

        [Display(Name = "Turma")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(20, ErrorMessage = "O campo {0} pode ter no máximo 20 caracteres.")]
        public string Turma { get; set; }

        [Display(Name = "Escolaridade")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(50, ErrorMessage = "O campo {0} pode ter no máximo 20 caracteres.")]
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
        public string Cep { get; set; }

        [Display(Name = "Estado")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Estado { get; set; }

        [Display(Name = "Telefone Residencial")]
        [DataType(DataType.PhoneNumber)]
        public string TelefoneResidencial { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Telefone Celular")]
        [DataType(DataType.PhoneNumber)]
        public string TelefoneCelular { get; set; }

        [Display(Name = "E-mail")]
        [EmailAddress]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Email { get; set; }

        [Display(Name = "Data de Matrícula")]
        [DataType(DataType.Date)]
        public DateTime DataMatricula { get; set; }

        [Display(Name = "Data de Desligamento")]
        [DataType(DataType.Date)]
        public DateTime DataDesligamento { get; set; }

        [Range(10, 100, ErrorMessage = "O valor para a {0} deve estar entre R$ 10,00 e R$ 100,00.")]
        [Display(Name = "Cota-parte")]
        [DataType(DataType.Currency, ErrorMessage = "O campo {0} deve ser um número.")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal CotaParte { get; set; }

        [Display(Name = "Matrícula")]
        public StatusMatricula StatusMatricula { get; set; } = StatusMatricula.Aguardando;

        /* EF Relations */
        public Curso Curso { get; set; }
    }
}
