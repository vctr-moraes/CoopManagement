<?php 

    namespace App\Controller\Curso;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use App\Entity\Curso\Curso;

    class CursoController extends AbstractController
    {
        public function curso()
        {
            return $this->render('curso/curso.html.twig');
        }

        public function cadastrar()
        {
            return $this->render('curso/cadastrar.html.twig');
        }

    }


?>