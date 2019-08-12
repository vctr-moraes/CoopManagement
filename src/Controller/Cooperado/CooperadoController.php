<?php
    
    namespace App\Controller\Cooperado;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use App\Entity\Cooperado\Cooperado;

    class CooperadoController extends AbstractController
    {
        /**
         * Retorna a view principal para gerenciamento de cooperados
         */
        public function cooperado()
        {
            return $this->render('cooperado/cooperado.html.twig');
        }

        /**
         * Retorna a view com a lista de cooperados matriculados
         */
        public function listar()
        {
            $cooperados = $this->getDoctrine()
                ->getRepository(Cooperado::class)->findAll();

            if (!$cooperados) {
                // throw $this->createNotFoundException(
                //     'Cooperado não encontrado'
                // );
            }

            $dados = array(
                'cooperados' => $cooperados
            );

            return $this->render('cooperado/listar.html.twig', $dados);
        }

        /**
         * Retorna a view para cadastro de cooperado
         */
        public function cadastrar()
        {
            return $this->render('cooperado/cadastrar.html.twig');
        }

        /**
         * Retorna a view para lista de cooperados desligados
         */
        public function desligados()
        {
            return $this->render('cooperado/desligados.html.twig');
        }

        /**
         * Retorna a view para lista de novas matrículas realizadas para serem confirmadas
         */
        public function novos()
        {
            $cooperados = $this->getDoctrine()
                ->getRepository(Cooperado::class)->findAll();

            $dados = array(
                'cooperados' => $cooperados
            );

            return $this->render('cooperado/novos.html.twig', $dados);
        }
    }
?>