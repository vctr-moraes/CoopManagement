<?php

    namespace App\Entity\Curso;

    use Doctrine\ORM\Mapping as ORM;

    /**
     * @ORM\Entity(repositoryClass="App\Repository\CursoRepository")
     */
    class Curso
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
         * @ORM\Column(type="string", length=50)
         */
        private $grau;

        /**
         * @return mixed
         */
        public function getId()
        {
            return $this->id;
        }

        /**
         * @param mixed $id
         * @return Curso
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
         * @return Curso
         */
        public function setNome($nome): Curso
        {
            $this->nome = $nome;
            return $this;
        }

        /**
         * @return string
         */
        public function getGrau(): string
        {
            return $this->grau;
        }

        /**
         * @param string $grau
         * @return Curso
         */
        public function setGrau($grau): Curso
        {
            $this->grau = $grau;
            return $this;
        }
    }
?>