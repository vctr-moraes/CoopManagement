<?php

    namespace App\Controller\Cooperado;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use App\Entity\Cooperado\Cooperado;

    class SalvarCooperadoController extends AbstractController
    {
        /**
         * Função salvar: irá receber os dados do formulário e atribuí-los aos atributos do objeto $novoCooperado
         */
        public function salvar()
        {
            $nome = $_POST['nome'];
            $sexo = $_POST['sexo'];
            $estadoCivil = $_POST['estadoCivil'];
            $dataNascimento = $_POST['dataNascimento'];

            $novoCooperado = new Cooperado();

            $novoCooperado->setNome($nome);
            $novoCooperado->setSexo($sexo);
            $novoCooperado->setEstadoCivil($estadoCivil);
            $novoCooperado->setDataNascimento($dataNascimento);
            // $novoCooperado->setRacaCor($racaCor);
            // $novoCooperado->setNecessidadeEspecial($necessidadeEspecial);
            // $novoCooperado->setCpf($cpf);
            // $novoCooperado->setRg($rg);
            // $novoCooperado->setOrgaoExpedidorRg($orgaoExpedidorRg);
            // $novoCooperado->setDataExpedicaoRg($dataExpedicaoRg);
            // $novoCooperado->setNaturalidade($naturalidade);
            // $novoCooperado->setNomePai($nomePai);
            // $novoCooperado->setNomeMae($nomeMae);
            // $novoCooperado->setRendaFamiliar($rendaFamiliar);
            // $novoCooperado->setCurso($curso);
            // $novoCooperado->setTurma($turma);
            // $novoCooperado->setEscolaridade($escolaridade);
            // $novoCooperado->setRua($rua);
            // $novoCooperado->setBairro($bairro);
            // $novoCooperado->setCidade($cidade);
            // $novoCooperado->setCep($cep);
            // $novoCooperado->setEstado($estado);
            // $novoCooperado->setTelefoneResidencial($telefoneResidencial);
            // $novoCooperado->setTelefoneCelular($telefoneCelular);
            // $novoCooperado->setEmail($email);
            // $novoCooperado->setDataMatricula($dataMatricula);
            // $novoCooperado->setCotaParte($cotaParte);

            $dados = array(
                'cooperado' => $novoCooperado
            );

            return $this->render('cooperado/teste.html.twig', $dados);
        }
    }
?>