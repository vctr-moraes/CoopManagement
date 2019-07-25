<?php

    namespace App\Controller\Usuario;
    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;

    use Symfony\Component\HttpFoundation\Response;

    class UsuarioController extends AbstractController
    {
        /**
         * Retorna a view principal para gerenciamento de usuários
         */
        public function usuario()
        {
            return $this->render('usuario/usuario.html.twig');
        }

        /**
         * Retorna a view para login no sistema
         */
        public function loginUsuario()
        {
            return $this->render('usuario/login.html.twig');
        }
    }