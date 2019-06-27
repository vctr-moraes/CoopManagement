<?php
    
    namespace App\Controller\Cooperado;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;

    class CadastrarCooperadoController extends AbstractController
    {
        public function cadastrarCooperado()
        {
            return $this->render('cooperado/cadastrar.html.twig');
        }
    }
?>