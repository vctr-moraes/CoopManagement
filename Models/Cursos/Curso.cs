using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models
{
    public class Curso : Entidade
    {
        private static readonly string Tecnico = "Técnico";
        private static readonly string Superior = "Superior";

        private string _nome;
        private string _grau;
        private static readonly string[] Graus = { Tecnico, Superior };
        private readonly List<Cooperado> _cooperados = new List<Cooperado>();

        public string Nome
        {
            get => _nome;

            set
            {
                DomainException.When(string.IsNullOrEmpty(value), "O campo Nome é obrigatório.");
                DomainException.When(value.Trim().Length > 100, "O campo Nome pode ter no máximo 40 caracteres.");
                _nome = value;
            }
        }

        public string Grau
        {
            get => _grau;

            set
            {
                DomainException.When(string.IsNullOrEmpty(value), "O campo Grau é obrigatório.");
                DomainException.When(Graus.Contains(value), "O Grau informado é inválido.");
            }
        }

        public IEnumerable<Cooperado> Cooperados => _cooperados;
    }
}
