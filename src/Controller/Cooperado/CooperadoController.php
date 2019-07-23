<?php
    
    namespace App\Controller\Cooperado;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use App\Entity\Cooperado\Cooperado;

    class CooperadoController extends AbstractController
    {
        public function cooperado()
        {
            return $this->render('cooperado/cooperado.html.twig');
        }

        public function cadastrar()
        {
            return $this->render('cooperado/cadastrar.html.twig');
        }

        public function desligados()
        {
            return $this->render('cooperado/desligados.html.twig');
        }

        public function novos()
        {
            return $this->render('cooperado/novos.html.twig');
        }
    }
?>