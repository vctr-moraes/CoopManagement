using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using CoopManagement.Models.Cooperados;

namespace CoopManagement.ViewsModels
{
    public class CooperadoDetailsViewModel
    {
        public CooperadoDetailsViewModel() { }

        public CooperadoDetailsViewModel(Cooperado cooperado)
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
            CotaParte = cooperado.CotaParte.ToString();
            StatusMatricula = (StatusMatriculaViewModel)cooperado.StatusMatricula;
        }

        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sexo")]
        public SexoViewModel Sexo { get; set; }

        [Display(Name = "Estado Civil")]
        public EstadoCivilViewModel EstadoCivil { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Raça/Cor")]
        public RacaCorViewModel RacaCor { get; set; }

        [Display(Name = "Necessidades Especiais")]
        public NecessidadeEspecialViewModel NecessidadeEspecial { get; set; }

        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Display(Name = "Órgão Expedidor")]
        public string OrgaoExpedidorRg { get; set; }

        [Display(Name = "Data de Expedição")]
        [DataType(DataType.Date)]
        public DateTime DataExpedicaoRg { get; set; }

        [Display(Name = "Naturalidade")]
        public string Naturalidade { get; set; }

        [Display(Name = "Nacionalidade")]
        public string Nacionalidade { get; set; }

        [Display(Name = "Nome do Pai")]
        public string NomePai { get; set; }

        [Display(Name = "Nome da Mãe")]
        public string NomeMae { get; set; }

        [Display(Name = "Renda Familiar")]
        public string RendaFamiliar { get; set; }

        [Display(Name = "Matrícula Acadêmica")]
        public string Matricula { get; set; }

        public CursoViewModel Curso { get; set; }

        public IEnumerable<SelectListItem> Cursos { get; set; }

        [Display(Name = "Curso")]
        public Guid CursoId { get; set; }

        [Display(Name = "Turma")]
        public string Turma { get; set; }

        [Display(Name = "Escolaridade")]
        public EscolaridadeViewModel Escolaridade { get; set; }

        [Display(Name = "Logradouro")]
        public string Logradouro { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Telefone Residencial")]
        [DataType(DataType.PhoneNumber)]
        public string TelefoneResidencial { get; set; }

        [Display(Name = "Telefone Celular")]
        [DataType(DataType.PhoneNumber)]
        public string TelefoneCelular { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Display(Name = "Data de Matrícula")]
        [DataType(DataType.Date)]
        public DateTime DataMatricula { get; set; }

        [Display(Name = "Data de Desligamento")]
        [DataType(DataType.Date)]
        public DateTime DataDesligamento { get; set; }

        [Display(Name = "Cota-parte")]
        [DataType(DataType.Text)]
        public string CotaParte { get; set; }

        [Display(Name = "Matrícula")]
        public StatusMatriculaViewModel StatusMatricula { get; set; }
    }
}
