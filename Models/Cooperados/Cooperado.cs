using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoopManagement.Models
{
    public class Cooperado : Entidade
    {
        private static readonly string Masculino = "Masculino";
        private static readonly string Feminino = "Feminino";

        private static readonly string Solteiro = "Solteiro";
        private static readonly string Casado = "Casado(a)";
        private static readonly string Viuvo = "Viúvo(a)";
        private static readonly string Divorciado = "Divorciado(a)";
        private static readonly string Separado = "Separado(a)";

        private static readonly string Branca = "Branca";
        private static readonly string Negra = "Negra";
        private static readonly string Parda = "Parda";
        private static readonly string Amarela = "Amarela";
        private static readonly string Indigena = "Indígena";

        private static readonly string Nenhuma = "Nenhuma";
        private static readonly string Fisica = "Física";
        private static readonly string Mental = "Mental";
        private static readonly string Visual = "Visual";
        private static readonly string Auditiva = "Auditiva";

        private string _nome;
        private string _sexo;
        private static readonly string[] Sexos = { Masculino, Feminino };
        private string _estadoCivil;
        private static readonly string[] EstadosCivil = { Solteiro, Casado, Viuvo, Divorciado, Separado };
        private DateTime _dataNascimento;
        private string _racaCor;
        private static readonly string[] RacasCor = { Branca, Negra, Parda, Amarela, Indigena };
        private string _necessidadeEspecial;
        private static readonly string[] NecessidadesEspecial = { Nenhuma, Fisica, Mental, Visual, Auditiva };
        private string _cpf;
        private string? _rg;
        private string _orgaoExpedidorRg;
        private DateTime? _dataExpedicaoRg;
        private string _naturalidade;
        private string _nacionalidade;
        private string? _nomePai;
        private string? _nomeMae;
        private double _rendaFamiliar;
        private string _matricula;
        private Curso _curso;
        private string _turma;
        private string _escolaridade;
        private string _rua;
        private string _bairro;
        private string _cidade;
        private string _cep;
        private string _estado;
        private string _telefoneResidencial;
        private string _telefoneCelular;
        private string _email;
        private DateTime _dataMatricula;
        private DateTime? _dataDesligamento;
        private double _cotaParte;
        private string _statusMatricula;

        public string Nome
        {
            get => _nome;

            set
            {
                _nome = value;
            }
        }

        public string Sexo
        {
            get => _sexo;

            set
            {
                DomainException.When(string.IsNullOrEmpty(value), "O campo Sexo é obrigatório.");
                DomainException.When(Sexos.Contains(value), "O Sexo informado é inválido.");
                _sexo = value;
            }
        }

        public string EstadoCivil
        {
            get => _estadoCivil;

            set
            {
                DomainException.When(string.IsNullOrEmpty(value), "O campo Estado Civil é obrigatório.");
                DomainException.When(EstadosCivil.Contains(value), "O Estado Civil informado é inválido.");
                _estadoCivil = value;
            }
        }

        public DateTime DataNascimento
        {
            get => _dataNascimento;

            set
            {
                _dataNascimento = value;
            }
        }

        public string RacaCor
        {
            get => _racaCor;

            set
            {
                DomainException.When(string.IsNullOrEmpty(value), "O campo Raça/Cor é obrigatório.");
                DomainException.When(EstadosCivil.Contains(value), "A Raça/Cor informada é inválida.");
                _racaCor = value;
            }
        }

        public string NecessidadeEspecial
        {
            get => _necessidadeEspecial;

            set
            {
                DomainException.When(string.IsNullOrEmpty(value), "O campo Necessidade Especial é obrigatório.");
                DomainException.When(EstadosCivil.Contains(value), "A Necessidade Especial informada é inválida.");
                _necessidadeEspecial = value;
            }
        }

        public string Cpf
        {
            get => _cpf;

            set
            {
                _cpf = value;
            }
        }

        public string Rg
        {
            get => _rg;

            set
            {
                _rg = value;
            }
        }

        public string OrgaoExpedidorRg
        {
            get => _orgaoExpedidorRg;

            set
            {
                _orgaoExpedidorRg = value;
            }
        }

        public DateTime? DataExpedicaoRg
        {
            get => _dataExpedicaoRg;

            set
            {
                _dataExpedicaoRg = value;
            }
        }

        public string Naturalidade
        {
            get => _naturalidade;

            set
            {
                _naturalidade = value;
            }
        }

        public string Nacionalidade
        {
            get => _nacionalidade;

            set
            {
                _nacionalidade = value;
            }
        }

        public string? NomePai
        {
            get => _nomePai;

            set
            {
                _nomePai = value;
            }
        }

        public string? NomeMae
        {
            get => _nomeMae;

            set
            {
                _nomeMae = value;
            }
        }

        public double RendaFamiliar
        {
            get => _rendaFamiliar;

            set
            {
                _rendaFamiliar = value;
            }
        }

        public string Matricula
        {
            get => _matricula;

            set
            {
                _matricula = value;
            }
        }

        public int? CursoId { get; set; }

        public virtual Curso Curso
        {
            get => _curso;

            set
            {
                _curso = value;
            }
        }

        public string Turma
        {
            get => _turma;

            set
            {
                _turma = value;
            }
        }

        public string Escolaridade
        {
            get => _escolaridade;

            set
            {
                _escolaridade = value;
            }
        }

        public string Rua
        {
            get => _rua;

            set
            {
                _rua = value;
            }
        }

        public string Bairro
        {
            get => _bairro;

            set
            {
                _bairro = value;
            }
        }

        public string Cidade
        {
            get => _cidade;

            set
            {
                _cidade = value;
            }
        }

        public string Cep
        {
            get => _cep;

            set
            {
                _cep = value;
            }
        }

        public string Estado
        {
            get => _estado;

            set
            {
                _estado = value;
            }
        }

        public string TelefoneResidencial
        {
            get => _telefoneResidencial;

            set
            {
                _telefoneResidencial = value;
            }
        }

        public string TelefoneCelular
        {
            get => _telefoneCelular;

            set
            {
                _telefoneCelular = value;
            }
        }

        public string Email
        {
            get => _email;

            set
            {
                _email = value;
            }
        }

        public DateTime DataMatricula
        {
            get => _dataMatricula;

            set
            {
                _dataMatricula = value;
            }
        }

        public DateTime? DataDesligamento
        {
            get => _dataDesligamento;

            set
            {
                _dataDesligamento = value;
            }
        }

        public double CotaParte
        {
            get => _cotaParte;

            set
            {
                _cotaParte = value;
            }
        }

        public string StatusMatricula
        {
            get => _statusMatricula;

            set
            {
                _statusMatricula = value;
            }
        }
    }
}
