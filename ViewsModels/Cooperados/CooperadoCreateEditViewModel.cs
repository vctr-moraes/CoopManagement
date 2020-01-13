using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CoopManagement.Models;

namespace CoopManagement.ViewsModels.Cooperados
{
    public class CooperadoCreateEditViewModel
    {
        public CooperadoCreateEditViewModel() { }

        public CooperadoCreateEditViewModel(Cooperado cooperado)
        {
            Id = cooperado.Id;
            Nome = cooperado.Nome;
            Sexo = cooperado.Sexo;
            EstadoCivil = cooperado.EstadoCivil;
            DataNascimento = cooperado.DataNascimento;
            RacaCor = cooperado.RacaCor;
            NecessidadeEspecial = cooperado.NecessidadeEspecial;
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
            Curso = cooperado.Curso;
            Turma = cooperado.Turma;
            Escolaridade = cooperado.Escolaridade;
            Rua = cooperado.Rua;
            Bairro = cooperado.Bairro;
            Cidade = cooperado.Bairro;
            Cep = cooperado.Cep;
            Estado = cooperado.Estado;
            TelefoneResidencial = cooperado.TelefoneResidencial;
            TelefoneCelular = cooperado.TelefoneCelular;
            Email = cooperado.Email;
            DataMatricula = cooperado.DataMatricula;
            DataDesligamento = cooperado.DataDesligamento;
            CotaParte = cooperado.CotaParte;
            StatusMatricula = cooperado.StatusMatricula;
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Sexo é obrigatório.")]
        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "O campo Estado civil é obrigatório.")]
        [Display(Name = "Estado civil")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage = "O campo Data de nascimento é obrigatório.")]
        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo Raça/cor é obrigatório.")]
        [Display(Name = "Raça/cor")]
        public string RacaCor { get; set; }

        [Required(ErrorMessage = "O campo Necessidade especial é obrigatório.")]
        [Display(Name = "Necessidade especial")]
        public string NecessidadeEspecial { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Display(Name = "Órgão expedidor")]
        public string OrgaoExpedidorRg { get; set; }

        [Display(Name = "Data de expedição")]
        public DateTime? DataExpedicaoRg { get; set; }

        [Required(ErrorMessage = "O campo Naturalidade é obrigatório.")]
        [Display(Name = "Naturalidade")]
        public string Naturalidade { get; set; }

        [Required(ErrorMessage = "O campo Nacionalidade é obrigatório.")]
        [Display(Name = "Nacionalidade")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "O campo Nome do pai é obrigatório.")]
        [Display(Name = "Nome do pai")]
        public string NomePai { get; set; }

        [Required(ErrorMessage = "O campo Nome da mãe é obrigatório.")]
        [Display(Name = "Nome da mãe")]
        public string NomeMae { get; set; }

        [Display(Name = "Renda familiar")]
        public double RendaFamiliar { get; set; }

        [Required(ErrorMessage = "O campo Matricula é obrigatório.")]
        [Display(Name = "Matricula")]
        public string Matricula { get; set; }

        [Required(ErrorMessage = "O campo Curso é obrigatório.")]
        [Display(Name = "Curso")]
        public Curso Curso { get; set; }

        [Required(ErrorMessage = "O campo Turma é obrigatório.")]
        [Display(Name = "Turma")]
        public string Turma { get; set; }

        [Required(ErrorMessage = "O campo Escolaridade é obrigatório.")]
        [Display(Name = "Escolaridade")]
        public string Escolaridade { get; set; }

        [Required(ErrorMessage = "O campo Rua é obrigatório.")]
        [Display(Name = "Rua")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "O campo Bairro é obrigatório.")]
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório.")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório.")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório.")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Telefone residencial")]
        public string TelefoneResidencial { get; set; }

        [Required(ErrorMessage = "O campo Telefone celular é obrigatório.")]
        [Display(Name = "Telefone celular")]
        public string TelefoneCelular { get; set; }

        [Required(ErrorMessage = "O campo E-mail é obrigatório.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Data de matrícula é obrigatório.")]
        [Display(Name = "Data de matrícula")]
        public DateTime DataMatricula { get; set; }

        [Display(Name = "Data de desligamento")]
        public DateTime? DataDesligamento { get; set; }

        [Display(Name = "Cota parte")]
        public double CotaParte { get; set; }

        [Display(Name = "Status da matrícula")]
        public string StatusMatricula { get; set; }
    }
}
