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
            $cursos = $this->getDoctrine()
                ->getRepository(Curso::class)->findAll();

            if (!$cursos) {
                // throw $this->createNotFoundException(
                //     'Curso não encontrado'
                // );
            }

            $dados = array(
                'cursos' => $cursos
            );

            return $this->render('curso/curso.html.twig', $dados);
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