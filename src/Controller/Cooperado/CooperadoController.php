<?php

namespace App\Controller\Cooperado;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use App\Entity\Cooperado\Cooperado;
use App\Entity\Curso\Curso;

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
            ->getRepository(Cooperado::class)->findByStatus(
                array(
                    'status' => 'AT'
                )
            );

        if (! $cooperados) {
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
        $cursos = $this->getDoctrine()
            ->getRepository(Curso::class)->findAll();
        
        $dados = array(
            'cursos' => $cursos
        );

        return $this->render('cooperado/cadastrar.html.twig', $dados);
    }

    /**
     * Retorna a view para lista de cooperados desligados
     */
    public function desligados()
    {
        $cooperados = $this->getDoctrine()
            ->getRepository(Cooperado::class)->findByStatus(
                array(
                    'status' => 'DE'
                )
            );
        
            $dados = array(
                'cooperados' => $cooperados
            );
            
        return $this->render('cooperado/desligados.html.twig', $dados);
    }

    /**
     * Retorna a view para lista de novas matrículas realizadas para serem confirmadas
     */
    public function novos()
    {
        $cooperados = $this->getDoctrine()
            ->getRepository(Cooperado::class)->findByStatus(
                array(
                    'status' => 'AG'
                )
            );

        $dados = array(
            'cooperados' => $cooperados
        );

        return $this->render('cooperado/novos.html.twig', $dados);
    }

    /**
     * @return Response
     * Altera o status de AG (aguardando) para AT (ativo) do novo cooperado
     */
    public function efetivar($id = 8)
    {
        $em = $this->getDoctrine()->getManager();
        $cooperado = $em->getRepository(Cooperado::class)->find($id);

        $cooperado->setStatus('AT');
        $em->flush();

        return $this->redirect($this->generateUrl('novasMatriculas'));
        // return $this->render('cooperado/novos.html.twig');
        // return $this->redirectToRoute('novasMatriculas');
    }

    public function desligar($id = 8)
    {
        $em = $this->getDoctrine()->getManager();
        $cooperado = $em->getRepository(Cooperado::class)->find($id);

        $cooperado->setStatus('DE')
            ->setDataDesligamento(\DateTime::createFromFormat('Y-m-d', date('Y-m-d')));
        $em->flush();

        return $this->redirectToRoute('cooperados');
    }
}