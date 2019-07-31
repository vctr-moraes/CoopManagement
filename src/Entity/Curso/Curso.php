<?php

    namespace App\Entity\Curso;

    class Curso
    {
        private $id;
        private $nome;
        private $grau;

        public function getId()
        {
            return $this->id;
        }

        public function setId($id)
        {
            $this->id = $id;
        }

        public function getNome()
        {
            return $this->nome;
        }

        public function setNome($nome)
        {
            $this->nome = $nome;
        }

        public function getGrau()
        {
            return $this->grau;
        }

        public function setGrau($grau)
        {
            $this->grau = $grau;
        }
    }
?>