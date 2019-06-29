<?php
    
    namespace App\Controller\Cooperado;

    use Symfony\Bundle\FrameworkBundle\Controller\AbstractController;
    use Symfony\Component\HttpFoundation\Response;
    use Symfony\ser\Entity\Cooperado;

    class CooperadoController extends AbstractController
    {
        public function cooperado()
        {
            return $this->render('cooperado/cooperado.html.twig');
        }

        public function cadastrar()
        {
            return $this->render('cooperado/cadastrar.html.twig');
        }

        public function salvar()
        {
            $nome = $_POST['nome'];
            $sexo = $_POST['sexo'];
            $estadoCivil = $_POST['estadoCivil'];
            $dataNascimento = $_POST['dataNascimento'];
            $racaCor = $_POST['racaCor'];
            $necessidadeEspecial = $_POST['necessidadeEspecial'];
            $cpf = $_POST['cpf'];
            $rg = $_POST['rg'];
            $orgaoExpedidorRg = $_POST['orgaoExpedidorRg'];
            $dataExpedicaoRg = $_POST['dataExpedicaoRg'];
            $naturalidade = $_POST['naturalidade'];
            $nacionalidade = $_POST['nacionalidade'];
            $nomePai = $_POST['nomePai'];
            $nomeMae = $_POST['nomeMae'];
            $rendaFamiliar = $_POST['rendaFamiliar'];
            $curso = $_POST['curso'];
            $turma = $_POST['turma'];
            $escolaridade = $_POST['escolaridade'];
            $rua = $_POST['rua'];
            $bairro = $_POST['bairro'];
            $cidade = $_POST['cidade'];
            $cep = $_POST['cep'];
            $estado = $_POST['estado'];
            $telefoneResidencial = $_POST['telefoneResidencial'];
            $telefoneCelular = $_POST['telefoneCelular'];
            $email = $_POST['email'];
            $dataMatricula = $_POST['dataMatricula'];

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

            
        }
    }
?>