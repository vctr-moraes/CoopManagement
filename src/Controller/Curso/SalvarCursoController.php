<?php

    namespace App\Controller\Curso;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use App\Entity\Curso\Curso;

    class SalvarCursoController extends AbstractController
    {
        public function salvar()
        {
            $nome = $_POST['nome'];
            $grau = $_POST['grau'];

            $novoCurso = new Curso();

            $novoCurso->setNome($nome);
            $novoCurso->setGrau($grau);

            $dados = array(
                'curso' => $novoCurso
            );

            return $this->render('cooperado/teste.html.twig', $dados);
        }
    }

?>