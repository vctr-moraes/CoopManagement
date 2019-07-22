<?php

    namespace App\Controller\Usuario;
    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;

    use Symfony\Component\HttpFoundation\Response;

    class UsuarioController extends AbstractController
    {
        public function usuario()
        {
            return $this->render('usuario/usuario.html.twig');
        }

        public function cadastrarUsuario()
        {
            return $this->render('usuario/login.html.twig');
        }
    }