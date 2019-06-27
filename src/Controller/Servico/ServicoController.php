<?php
    
    namespace App\Controller\Servico;
    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;

    use Symfony\Component\HttpFoundation\Response;

    class ServicoController extends AbstractController
    {
        public function servico()
        {
            return $this->render('servico/servico.html.twig');
        }
    }