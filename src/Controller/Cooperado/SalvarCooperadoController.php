<?php

namespace App\Controller\Cooperado;

use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
use Symfony\Component\HttpFoundation\Response;
use App\Entity\Cooperado\Cooperado;
use Symfony\Component\BrowserKit\Request;

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

        $novoCooperado = new Cooperado();

        $novoCooperado->setNome($nome);
        $novoCooperado->setSexo($sexo);
        $novoCooperado->setEstadoCivil($estadoCivil);
        $novoCooperado->setDataNascimento($dataNascimento);
        $novoCooperado->setRacaCor($racaCor);
        $novoCooperado->setNecessidadeEspecial($necessidadeEspecial);
        $novoCooperado->setCpf($cpf);
        $novoCooperado->setRg($rg);
        $novoCooperado->setOrgaoExpedidorRg($orgaoExpedidorRg);
        $novoCooperado->setDataExpedicaoRg($dataExpedicaoRg);
        $novoCooperado->setNaturalidade($naturalidade);
        $novoCooperado->setNomePai($nomePai);
        $novoCooperado->setNomeMae($nomeMae);
        $novoCooperado->setRendaFamiliar($rendaFamiliar);
        $novoCooperado->setCurso($curso);
        $novoCooperado->setTurma($turma);
        $novoCooperado->setEscolaridade($escolaridade);
        $novoCooperado->setRua($rua);
        $novoCooperado->setBairro($bairro);
        $novoCooperado->setCidade($cidade);
        $novoCooperado->setCep($cep);
        $novoCooperado->setEstado($estado);
        $novoCooperado->setTelefoneResidencial($telefoneResidencial);
        $novoCooperado->setTelefoneCelular($telefoneCelular);
        $novoCooperado->setEmail($email);
        $novoCooperado->setDataMatricula($dataMatricula);
        $novoCooperado->setCotaParte($cotaParte);

        $dados = array(
            'cooperado' => $novoCooperado
        );

        return $this->render('cooperado/teste.html.twig', $dados);
    }
}

?>