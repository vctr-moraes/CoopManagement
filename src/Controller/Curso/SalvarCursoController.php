<?php

    namespace App\Controller\Curso;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use App\Entity\Curso\Curso;

    class SalvarCursoController extends AbstractController
    {
        /**
         * @return Response
         */
        public function salvar(): Response
        {
            $nome = $_POST['nome'];
            $grau = $_POST['grau'];

            $ge = $this->getDoctrine()->getManager();

            $curso = new Curso();
            $curso->setNome($nome)->setGrau($grau);

            $ge->persist(($curso));
            $ge->flush();

            // return new Response("Curso cadastrado com sucesso!");

            $dados = array(
                'curso' => $curso
            );

            return $this->render('cooperado/teste.html.twig', $dados);
        }
    }

?>