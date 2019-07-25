<?php
// src/Controller/LuckyController.php
namespace App\Controller;
use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;

use Symfony\Component\HttpFoundation\Response;

class HomeController extends AbstractController
{
    public function index()
    {
        return $this->render('index.html.twig');
    }

    public function sobre()
    {
        return $this->render('sobre.html.twig');
    }
}