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

        /**
         * @return Response
         * 
         */
        public function novoCurso()
        {
            $ge = $this->getDoctrine()->getManager();

            $curso = new Curso();
            $curso->setNome("Análise de Sistemas")->setGrau("Superior");

            $ge->persist(($curso));
            $ge->flush();

            return new Response("Curso cadastrado com sucesso!");
        }

    }


?>