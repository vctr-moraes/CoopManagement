using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using CoopManagement.Models;

namespace CoopManagement.ViewsModels.Cooperados
{
    public class CooperadoDetailsViewModel
    {
        public CooperadoDetailsViewModel() { }

        public CooperadoDetailsViewModel(Cooperado cooperado)
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
        
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Estado civil")]
        public string EstadoCivil { get; set; }

        [Display(Name = "Data de nascimento")]
        public DateTime DataNascimento { get; set; }

        [Display(Name = "Raça/cor")]
        public string RacaCor { get; set; }

        [Display(Name = "Necessidade especial")]
        public string NecessidadeEspecial { get; set; }

        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Display(Name = "RG")]
        public string Rg { get; set; }

        [Display(Name = "Órgão expedidor")]
        public string OrgaoExpedidorRg { get; set; }

        [Display(Name = "Data de expedição")]
        public DateTime? DataExpedicaoRg { get; set; }

        [Display(Name = "Naturalidade")]
        public string Naturalidade { get; set; }

        [Display(Name = "Nacionalidade")]
        public string Nacionalidade { get; set; }

        [Display(Name = "Nome do pai")]
        public string NomePai { get; set; }

        [Display(Name = "Nome da mãe")]
        public string NomeMae { get; set; }

        [Display(Name = "Renda familiar")]
        public double RendaFamiliar { get; set; }

        [Display(Name = "Matricula")]
        public string Matricula { get; set; }

        [Display(Name = "Curso")]
        public Curso Curso { get; set; }

        [Display(Name = "Turma")]
        public string Turma { get; set; }

        [Display(Name = "Escolaridade")]
        public string Escolaridade { get; set; }

        [Display(Name = "Rua")]
        public string Rua { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Telefone residencial")]
        public string TelefoneResidencial { get; set; }

        [Display(Name = "Telefone celular")]
        public string TelefoneCelular { get; set; }

        [Display(Name = "E-mail")]
        public string Email { get; set; }

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
