using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models
{
    public class Curso : Entidade
    {
        private string _nome;
        private string _grau;
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
                DomainException.When(value.Trim().Length > 50, "O campo Grupo pode ter no máximo 50 caracteres.");
            }
        }

        public IEnumerable<Cooperado> Cooperados => _cooperados;
    }
}
