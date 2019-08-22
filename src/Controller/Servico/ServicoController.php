<?php

namespace App\Controller\Servico;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\Routing\Annotation\Route;
use Symfony\Component\HttpFoundation\Response;

class ServicoController extends AbstractController
{
    /**
     * Retorna a view para gerenciamento dos serviços prestados
     */
    public function servico()
    {
        return $this->render('servico/servico.html.twig');
    }
}