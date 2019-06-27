<?php
    
    namespace App\Controller\Cooperado;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;

    use Symfony\Component\HttpFoundation\Response;

    class CooperadoController extends AbstractController
    {
        public function cooperado()
        {
            return $this->render('cooperado/cooperado.html.twig');
        }

        public function cadastrarCooperado()
        {
            return $this->render('cooperado/cadastrar.html.twig');
        }
    }
?>