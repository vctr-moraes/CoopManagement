<?php

namespace App\Controller\Cooperado;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use Symfony\Component\HttpFoundation\Request;
// use Symfony\Component\BrowserKit\Request;
use App\Entity\Cooperado\Cooperado;
use App\Entity\Curso\Curso;
use \DateTime;

class SalvarCooperadoController extends AbstractController
{
    /**
     * @return Response
     */
    public function salvar(Request $request): Response
    {
        $nome = $request->request->get('nome');
        $sexo = $request->request->get('sexo');
        $estadoCivil = $request->request->get('estadoCivil');
        $dataNascimento = $request->request->get('dataNascimento');
        $racaCor = $request->request->get('racaCor');
        $necessidadeEspecial = $request->request->get('necessidadeEspecial');
        $cpf = $request->request->get('cpf');
        $rg = $request->request->get('rg');
        $orgaoExpedidorRg = $request->request->get('orgaoExpedidorRg');
        $dataExpedicaoRg = $request->request->get('dataExpedicaoRg');
        $naturalidade = $request->request->get('naturalidade');
        $nacionalidade = $request->request->get('nacionalidade');
        $nomePai = $request->request->get('nomePai');
        $nomeMae = $request->request->get('nomeMae');
        $rendaFamiliar = $request->request->get('rendaFamiliar');
        $matricula = $request->request->get('matricula');
        $curso_id = $request->request->get('curso');

        $objetoCurso = $this->getDoctrine()
            ->getRepository(Curso::class)->find($curso_id);
            
        $turma = $request->request->get('turma');
        $escolaridade = $request->request->get('escolaridade');
        $rua = $request->request->get('rua');
        $bairro = $request->request->get('bairro');
        $cidade = $request->request->get('cidade');
        $cep = $request->request->get('cep');
        $estado = $request->request->get('estado');
        $telefoneResidencial = $request->request->get('telefoneResidencial');
        $telefoneCelular = $request->request->get('telefoneCelular');
        $email = $request->request->get('email');
        // $dataMatricula = $request->get('dataMatricula');
        $dataMatricula = (\DateTime::createFromFormat('Y-m-d', date('Y-m-d')));
        $cotaParte = $request->request->get('cotaParte');
        $status = "AG";

        $ge = $this->getDoctrine()->getManager();

        $cooperado = new Cooperado();

        $cooperado->setNome($nome)
            ->setSexo($sexo)
            ->setEstadoCivil($estadoCivil)
            ->setDataNascimento(\DateTime::createFromFormat('Y-m-d', $dataNascimento))
            ->setRacaCor($racaCor)
            ->setNecessidadeEspecial($necessidadeEspecial)
            ->setCpf($cpf)
            ->setRg($rg)
            ->setOrgaoExpedidorRg($orgaoExpedidorRg)
            ->setDataExpedicaoRg(\DateTime::createFromFormat('Y-m-d', $dataExpedicaoRg))
            ->setNaturalidade($naturalidade)
            ->setNacionalidade($nacionalidade)
            ->setNomePai($nomePai)
            ->setNomeMae($nomeMae)
            ->setRendaFamiliar((float) $rendaFamiliar)
            ->setMatricula($matricula)
            ->setCurso($objetoCurso)
            ->setTurma($turma)
            ->setEscolaridade($escolaridade)
            ->setRua($rua)
            ->setBairro($bairro)
            ->setCidade($cidade)
            ->setCep($cep)
            ->setEstado($estado)
            ->setTelefoneResidencial($telefoneResidencial)
            ->setTelefoneCelular($telefoneCelular)
            ->setEmail($email)
            // ->setDataMatricula(\DateTime::createFromFormat('Y-m-d', date('Y-m-d')))
            ->setDataMatricula($dataMatricula)
            ->setCotaParte($cotaParte)
            ->setStatus($status);

        $ge->persist($cooperado);
        $ge->flush();

        return $this->redirectToRoute('index');
    }
}

?>