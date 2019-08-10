<?php

    namespace App\Entity\Cooperado;
    use Doctrine\ORM\Mapping as ORM;

    /**
     * ORM\Entity(repositoryClass="App\Repository\CooperadoRepository")
     */
    class Cooperadohgfghfh
    {
        /**
         * @ORM\Id()
         * @ORM\GeneratedValue()
         * @ORM\Column(type="integer")
         */
        private $id;

        /**
         * @var string
         * @ORM\Column(type="string", length=100)
         */
        private $nome;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $sexo;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $estadoCivil;

        /**
         * @var date
         * @ORM\Column(type="date")
         */
        private $dataNascimento;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $racaCor;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $necessidadeEspecial;

        /**
         * @var string
         * @ORM\Column(type="string", length=15)
         */
        private $cpf;

        /**
         * @var string
         * @ORM\Column(type="string", length=15)
         */
        private $rg;

        /**
         * @var string
         * @ORM\Column(type="string", length=10)
         */
        private $orgaoExpedidorRg;

        /**
         * @var string
         * @ORM\Column(type="string", length=10)
         */
        private $dataExpedicaoRg;
        
        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $naturalidade;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $nacionalidade;

        /**
         * @var string
         * @ORM\Column(type="string", length=100)
         */
        private $nomePai;

        /**
         * @var string
         * @ORM\Column(type="string", length=100)
         */
        private $nomeMae;

        /**
         * @var float
         * @ORM\Column(type="float")
         */
        private $rendaFamiliar;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $matricula;

        /**
         * @var Curso
         * @ORM\Column(type="Curso")
         */
        private $curso;

        /**
         * @var string
         * @ORM\Column(type="string", length=10)
         */
        private $turma;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $escolaridade;
        
        /**
         * @var string
         * @ORM\Column(type="string", length=100)
         */
        private $rua;

        /**
         * @var string
         * @ORM\Column(type="string", length=100)
         */
        private $bairro;

        /**
         * @var string
         * @ORM\Column(type="string", length=50)
         */
        private $cidade;

        /**
         * @var string
         * @ORM\Column(type="string", length=10)
         */
        private $cep;

        /**
         * @var string
         * @ORM\Column(type="string", length=20)
         */
        private $estado;
        
        /**
         * @var string
         * @ORM\Column(type="string", length=15)
         */
        private $telefoneResidencial;

        /**
         * @var string
         * @ORM\Column(type="string", length=15)
         */
        private $telefoneCelular;

        /**
         * @var string
         * @ORM\Column(type="string", length=100)
         */
        private $email;

        /**
         * @var date
         * @ORM\Column(type="date")
         */
        private $dataMatricula;

        /**
         * @var float
         * @ORM\Column(type="float")
         */
        private $cotaParte;

        // Geters & Seters

        /**
         * @return mixed
         */
        public function getId()
        {
            return $this->id;
        }

        /**
         * @param mixed $id
         * @return Cooperado
         */
        public function setId($id)
        {
            $this->id = $id;
            return $this;
        }

        /**
         * @return string
         */
        public function getNome(): string
        {
            return $this->nome;
        }

        /**
         * @param string $nome
         * @return Cooperado
         */
        public function setNome($nome): Cooperado
        {
            $this->nome = $nome;
            return $this;
        }

        /**
         * @return string
         */
        public function getSexo(): string
        {
            return $this->sexo;
        }

        /**
         * @param string $sexo
         * @return Cooperado
         */
        public function setSexo($sexo): Cooperado
        {
            $this->sexo = $sexo;
            return $this;
        }

        /**
         * @return string
         */
        public function getEstadoCivil(): string
        {
            return $this->estadoCivil;
        }

        /**
         * @param string $estadoCivil
         * @return Cooperado
         */
        public function setEstadoCivil($estadoCivil): Cooperado
        {
            $this->estadoCivil = $estadoCivil;
            return $this;
        }

        /**
         * @return date
         */
        public function getDataNascimento(): date
        {
            return $this->dataNascimento;
        }

        /**
         * @param date $dataNascimento
         * @return Cooperado
         */
        public function setDataNascimento($dataNascimento): Cooperado
        {
            $this->dataNascimento = $dataNascimento;
            return $this;
        }

        /**
         * @return string
         */
        public function getRacaCor(): string
        {
            return $this->racaCor;
        }

        /**
         * @param string $racaCor
         * @return Cooperado
         */
        public function setRacaCor($racaCor): Cooperado
        {
            $this->racaCor = $racaCor;
            return $this;
        }

        /**
         * @return string
         */
        public function getNecessidadeEspecial(): string
        {
            return $this->necessidadeEspecial;
        }

        /**
         * @param string $necessidadeEspecial
         * @return Cooperado
         */
        public function setNecessidadeEspecial($necessidadeEspecial): Cooperado
        {
            $this->necessidadeEspecial = $necessidadeEspecial;
            return $this;
        }

        /**
         * @return string
         */
        public function getCpf(): string
        {
            return $this->cpf;
        }

        /**
         * @param string $cpf
         * @return Cooperado
         */
        public function setCpf($cpf): Cooperado
        {
            $this->cpf = $cpf;
            return $this;
        }

        /**
         * @return string
         */
        public function getRg(): string
        {
            return $this->rg;
        }

        /**
         * @param string $rg
         * @return Cooperado
         */
        public function setRg($rg): Cooperado
        {
            $this->rg = $rg;
            return $this;
        }

        /**
         * @return string
         */
        public function getOrgaoExpedidorRg(): string
        {
            return $this->orgaoExpedidorRg;
        }

        /**
         * @param string $orgaoExpedidorRg
         * @return Cooperado
         */
        public function setOrgaoExpedidorRg($orgaoExpedidorRg): Cooperado
        {
            $this->orgaoExpedidorRg = $orgaoExpedidorRg;
            return $this;
        }

        /**
         * @return date
         */
        public function getDataExpedicaoRg(): date
        {
            return $this->dataExpedicaoRg;
        }

        /**
         * @param date $dataExpedicaoRg
         */
        public function setDataExpedicaoRg($dataExpedicaoRg): Cooperado
        {
            $this->dataExpedicaoRg = $dataExpedicaoRg;
            return $this;
        }

        /**
         * @return string
         */
        public function getNaturalidade(): string
        {
            return $this->naturalidade;
        }

        /**
         * @param string $naturalidade
         * @return Cooperado
         */
        public function setNaturalidade($naturalidade): Cooperado
        {
            $this->naturalidade = $naturalidade;
            return $this;
        }

        /**
         * @return string
         */
        public function getNacionalidade(): string
        {
            return $this->nacionalidade;
        }

        /**
         * @param string $nacionalidade
         * @return Cooperado
         */
        public function setNacionalidade($nacionalidade): Cooperado
        {
            $this->nacionalidade = $nacionalidade;
            return $this;
        }

        /**
         * @return string
         */
        public function getNomePai(): string
        {
            return $this->nomePai;
        }

        /**
         * @param string $nomePai
         * @return Cooperado
         */
        public function setNomePai($nomePai): Cooperado
        {
            $this->nomePai = $nomePai;
            return $this;
        }

        /**
         * @return string
         */
        public function getNomeMae(): string
        {
            return $this->nomeMae;
        }

        /**
         * @param string $nomeMae
         * @return Cooperado
         */
        public function setNomeMae($nomeMae): Cooperado
        {
            $this->nomeMae = $nomeMae;
            return $this;
        }

        /**
         * @return float
         */
        public function getRendaFamiliar(): float
        {
            return $this->rendaFamiliar;
        }

        /**
         * @param float $rendaFamiliar
         * @return Cooperado
         */
        public function setRendaFamiliar($rendaFamiliar): Cooperado
        {
            $this->rendaFamiliar = $rendaFamiliar;
            return $this;
        }

        /**
         * @return string
         */
        public function getMatricula(): string
        {
            return $this->matricula;
        }

        /**
         * @param string $matricula
         * @return Cooperado
         */
        public function setMatricula($matricula): Cooperado
        {
            $this->matricula = $matricula;
            return $this;
        }

        /**
         * @return Curso
         */
        public function getCurso(): Curso
        {
            return $this->curso;
        }

        /**
         * @param Curso $curso
         * @return Cooperado
         */
        public function setCurso($curso): Cooperado
        {
            $this->curso = $curso;
            return $this;
        }

        /**
         * @return string
         */
        public function getTurma(): string
        {
            return $this->turma;
        }

        /**
         * @param string $turma
         * @return Cooperado
         */
        public function setTurma($turma): Cooperado
        {
            $this->turma = $turma;
            return $this;
        }

        /**
         * @return string
         */
        public function getEscolaridade(): string
        {
            return $this->escolaridade;
        }

        /**
         * @param string $escolaridade
         * @return Cooperado
         */
        public function setEscolaridade($escolaridade): Cooperado
        {
            $this->escolaridade = $escolaridade;
            return $this;
        }

        /**
         * @return string
         */
        public function getRua(): string
        {
            return $this->rua;
        }

        /**
         * @param string $rua
         * @return Cooperado
         */
        public function setRua($rua): Cooperado
        {
            $this->rua = $rua;
            return $this;
        }

        /**
         * @return string
         */
        public function getBairro(): string
        {
            return $this->bairro;
        }

        /**
         * @param string $bairro
         * @return Cooperado
         */
        public function setBairro($bairro): Cooperado
        {
            $this->bairro = $bairro;
            return $this;
        }

        /**
         * @return string
         */
        public function getCidade(): string
        {
            return $this->cidade;
        }

        /**
         * @param string $cidade
         * @return Cooperado
         */
        public function setCidade($cidade): Cooperado
        {
            $this->cidade = $cidade;
            return $this;
        }

        /**
         * @return string
         */
        public function getCep(): string
        {
            return $this->cep;
        }

        /**
         * @param string $cep
         * @return Cooperado
         */
        public function setCep($cep): Cooperado
        {
            $this->cep = $cep;
            return $this;
        }

        /**
         * @return string
         */
        public function getEstado():string
        {
            return $this->estado;
        }

        /**
         * @param string $estado
         * @return Cooperado
         */
        public function setEstado($estado): Cooperado
        {
            $this->estado = $estado;
            return $this;
        }

        /**
         * @return string
         */
        public function getTelefoneResidencial(): string
        {
            return $this->telefoneResidencial;
        }

        /**
         * @param string $telefoneResidencial
         * @return Cooperado
         */
        public function setTelefoneResidencial($telefoneResidencial): Cooperado
        {
            $this->telefoneResidencial = $telefoneResidencial;
            return $this;
        }

        /**
         * @return string
         */
        public function getTelefoneCelular(): string
        {
            return $this->telefoneCelular;
        }

        /**
         * @param string $telefoneCelular
         * @return Cooperado
         */
        public function setTelefoneCelular($telefoneCelular): Cooperado
        {
            $this->telefoneCelular = $telefoneCelular;
            return $this;
        }

        /**
         * @return string
         */
        public function getEmail(): string
        {
            return $this->email;
        }

        /**
         * @param string $email
         * @return Cooperado
         */
        public function setEmail($email): Cooperado
        {
            $this->email = $email;
            return $this;
        }

        /**
         * @return date
         */
        public function getDataMatricula(): date
        {
            return $this->dataMatricula;
        }
        
        /**
         * @param date $dataMatricula
         * @return Cooperado
         */
        public function setDataMatricula($dataMatricula): Cooperado
        {
            $this->dataMatricula = $dataMatricula;
            return $this;
        }

        /**
         * @return float
         */
        public function getCotaParte(): float
        {
            return $this->cotaParte;
        }

        /**
         * @param float $cotaParte
         * @return Cooperado
         */
        public function setCotaParte($cotaParte): Cooperado
        {
            $this->$cotaParte = $cotaParte;
            return $this;
        }
    }
?>