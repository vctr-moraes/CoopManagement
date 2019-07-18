<?php

    namespace App\Entity\Cooperado;

    class Cooperado
    {
        /** Column(type="integer") */
        private $matricula;
        /** Column(type="string") */
        private $nome;
        /** Column(type="string") */
        private $sexo;
        /** Column(type="string") */
        private $estadoCivil;
        /** Column(type="date") */
        private $dataNascimento;
        /** Column(type="string") */
        private $racaCor;
        /** Column(type="string") */
        private $necessidadeEspecial;

        private $cpf;
        private $rg;
        private $orgaoExpedidorRg;
        private $dataExpedicaoRg;
        
        private $naturalidade;
        private $nacionalidade;
        private $nomePai;
        private $nomeMae;
        private $rendaFamiliar;

        private $curso;
        private $turma;
        private $escolaridade;
        
        private $rua;
        private $bairro;
        private $cidade;
        private $cep;
        private $estado;
        
        private $telefoneResidencial;
        private $telefoneCelular;
        private $email;
        private $dataMatricula;

        public function getMatricula()
        {
            return $this->matricula;
        }

        public function setMatricula($matricula)
        {
            $this->matricula = $matricula;
        }

        public function getNome()
        {
            return $this->nome;
        }

        public function setNome($nome)
        {
            $this->nome = $nome;
        }

        public function getSexo()
        {
            return $this->sexo;
        }

        public function setSexo($sexo)
        {
            $this->sexo = $sexo;
        }

        public function getEstadoCivil()
        {
            return $this->estadoCivil;
        }

        public function setEstadoCivil($estadoCivil)
        {
            $this->estadoCivil = $estadoCivil;
        }

        public function getDataNascimento()
        {
            return $this->dataNascimento;
        }

        public function setDataNascimento($dataNascimento)
        {
            $this->dataNascimento = $dataNascimento;
        }

        public function getRacaCor()
        {
            return $this->racaCor;
        }

        public function setRacaCor($racaCor)
        {
            $this->racaCor = $racaCor;
        }

        public function getNecessidadeEspecial()
        {
            return $this->necessidadeEspecial;
        }

        public function setNecessidadeEspecial($necessidadeEspecial)
        {
            $this->necessidadeEspecial = $necessidadeEspecial;
        }

        public function getCpf()
        {
            return $this->cpf;
        }

        public function setCpf($cpf)
        {
            $this->cpf = $cpf;
        }

        public function getRg()
        {
            return $this->rg;
        }

        public function setRg($rg)
        {
            $this->rg = $rg;
        }

        public function getOrgaoExpedidorRg()
        {
            return $this->orgaoExpedidorRg;
        }

        public function setOrgaoExpedidorRg($orgaoExpedidorRg)
        {
            $this->orgaoExpedidorRg = $orgaoExpedidorRg;
        }

        public function getDataExpedicaoRg()
        {
            return $this->dataExpedicaoRg;
        }

        public function setDataExpedicaoRg($dataExpedicaoRg)
        {
            $this->dataExpedicaoRg = $dataExpedicaoRg;
        }

        public function getNaturalidade()
        {
            return $this->naturalidade;
        }

        public function setNaturalidade($naturalidade)
        {
            $this->naturalidade = $naturalidade;
        }

        public function getNomePai()
        {
            return $this->nomePai;
        }

        public function setNomePai($nomePai)
        {
            $this->nomePai = $nomePai;
        }

        public function getNomeMae()
        {
            return $this->nomeMae;
        }

        public function setNomeMae($nomeMae)
        {
            $this->nomeMae = $nomeMae;
        }

        public function getRendaFamiliar()
        {
            return $this->rendaFamiliar;
        }

        public function setRendaFamiliar($rendaFamiliar)
        {
            $this->rendaFamiliar = $rendaFamiliar;
        }

        public function getCurso()
        {
            return $this->curso;
        }

        public function setCurso($curso)
        {
            $this->curso = $curso;
        }

        public function getTurma()
        {
            return $this->turma;
        }

        public function setTurma($turma)
        {
            $this->turma = $turma;
        }

        public function getEscolaridade()
        {
            return $this->escolaridade;
        }

        public function setEscolaridade($escolaridade)
        {
            $this->escolaridade = $escolaridade;
        }

        public function getRua()
        {
            return $this->rua;
        }

        public function setRua($rua)
        {
            $this->rua = $rua;
        }

        public function getBairro()
        {
            return $this->bairro;
        }

        public function setBairro($bairro)
        {
            $this->bairro = $bairro;
        }

        public function getCidade()
        {
            return $this->cidade;
        }

        public function setCidade($cidade)
        {
            $this->cidade = $cidade;
        }

        public function getCep()
        {
            return $this->cep;
        }

        public function setCep($cep)
        {
            $this->cep = $cep;
        }

        public function getEstado()
        {
            return $this->estado;
        }

        public function setEstado($estado)
        {
            $this->estado = $estado;
        }

        public function getTelefoneResidencial()
        {
            return $this->telefoneResidencial;
        }

        public function setTelefoneResidencial($telefoneResidencial)
        {
            $this->telefoneResidencial = $telefoneResidencial;
        }

        public function getTelefoneCelular()
        {
            return $this->telefoneCelular;
        }

        public function setTelefoneCelular($telefoneCelular)
        {
            $this->telefoneCelular = $telefoneCelular;
        }

        public function getEmail()
        {
            return $this->email;
        }

        public function setEmail($email)
        {
            $this->email = $email;
        }

        public function getDataMatricula()
        {
            return $this->dataMatricula;
        }
        
        public function setDataMatricula($dataMatricula)
        {
            $this->dataMatricula = $dataMatricula;
        }
    }
?>