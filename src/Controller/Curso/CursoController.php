<?php 

    namespace App\Controller\Curso;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use App\Entity\Curso\Curso;

    class CursoController extends AbstractController
    {
        /**
         * Retorna a view principal para gerenciamento de cursos
         */
        public function curso()
        {
            return $this->render('curso/curso.html.twig');
        }

        /**
         * Retorna a view para cadastro de cursos
         */
        public function cadastrar()
        {
            return $this->render('curso/cadastrar.html.twig');
        }

    }


?>