using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using CoopManagement.Models.Cooperados;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CoopManagement.ViewsModels
{
    public class CooperadoViewModel
    {
        public CooperadoViewModel() { }

        public CooperadoViewModel(Cooperado cooperado)
        {
            Id = cooperado.Id;
            Nome = cooperado.Nome;
            Sexo = (SexoViewModel)cooperado.Sexo;
            EstadoCivil = (EstadoCivilViewModel)cooperado.EstadoCivil;
            DataNascimento = cooperado.DataNascimento;
            RacaCor = (RacaCorViewModel)cooperado.RacaCor;
            NecessidadeEspecial = (NecessidadeEspecialViewModel)cooperado.NecessidadeEspecial;
            Cpf = cooperado.Cpf;
            Rg = cooperado.Rg;
            OrgaoExpedidorRg = cooperado.OrgaoExpedidorRg;
            DataExpedicaoRg = cooperado.DataExpedicaoRg;
            Naturalidade = cooperado.Naturalidade;
            Nacionalidade = cooperado.Nacionalidade;
            NomePai = cooperado.NomePai;
            NomeMae = cooperado.NomeMae;
            RendaFamiliar = cooperado.RendaFamiliar;
            Matricula = cooperado.Matricula;
            Curso = new CursoViewModel(cooperado.Curso);
            CursoId = cooperado.CursoId;
            Turma = cooperado.Turma;
            Escolaridade = (EscolaridadeViewModel)cooperado.Escolaridade;
            Logradouro = cooperado.Logradouro;
            Bairro = cooperado.Bairro;
            Cidade = cooperado.Cidade;
            Cep = cooperado.Cep;
            Estado = cooperado.Estado;
            TelefoneResidencial = cooperado.TelefoneResidencial;
            TelefoneCelular = cooperado.TelefoneCelular;
            Email = cooperado.Email;
            DataMatricula = cooperado.DataMatricula;
            DataDesligamento = cooperado.DataDesligamento;
            CotaParte = cooperado.CotaParte;
            StatusMatricula = (StatusMatriculaViewModel)cooperado.StatusMatricula;
        }

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} pode ter no máximo {1} caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Sexo")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public SexoViewModel Sexo { get; set; }

        [Display(Name = "Estado Civil")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public EstadoCivilViewModel EstadoCivil { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Raça/Cor")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public RacaCorViewModel RacaCor { get; set; }

        [Display(Name = "Necessidades Especiais")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public NecessidadeEspecialViewModel NecessidadeEspecial { get; set; }

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

        public CursoViewModel Curso { get; set; }

        public IEnumerable<SelectListItem> Cursos { get; set; }

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
        public EscolaridadeViewModel Escolaridade { get; set; }

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
        public StatusMatriculaViewModel StatusMatricula { get; set; } = StatusMatriculaViewModel.Aguardando;
    }
}
