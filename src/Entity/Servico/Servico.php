<?php

    namespace App\Entity\Servico;

    class Servico
    {
        private $codigo;
        private $descricao;

        public function getCodigo()
        {
            return $this->codigo;
        }

        public function setCodigo($codigo)
        {
            $this->codigo = $codigo;
        }

        public function getDescricao()
        {
            return $this->descricao;
        }

        public function setDescricao($descricao)
        {
            $this->descricao = $descricao;
        }
    }


?>