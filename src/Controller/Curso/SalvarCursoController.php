<?php

    namespace App\Controller\Curso;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use Symfony\Component\HttpFoundation\Request;
    use App\Entity\Curso\Curso;

    class SalvarCursoController extends AbstractController
    {
        /**
         * @return Response
         */
        public function salvar(Request $request): Response
        {
            // $nome = $_POST['nome'];
            // $grau = $_POST['grau'];

            // $request->query->get('page');
            $nome = $request->request->get('nome');
            $grau = $request->request->get('grau');

            $ge = $this->getDoctrine()->getManager();

            $curso = new Curso();
            $curso->setNome($nome)->setGrau($grau);

            $ge->persist($curso);
            $ge->flush();

            // return new Response("Curso cadastrado com sucesso!");

            // $dados = array(
            //     'curso' => $curso
            // );

            return $this->render('curso/cadastrar.html.twig');
        }
    }
?>