<?php

    namespace App\Controller\Usuario;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;

    class CadastrarUsuarioController extends AbstractController
    {
        public function cadastrarUsuario()
        {
            return $this->render('usuario/cadastrar.html.twig');
        }
    }
?>