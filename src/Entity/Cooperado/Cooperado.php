<?php

namespace App\Entity\Cooperado;

use App\Entity\Curso\Curso;
use Doctrine\ORM\Mapping as ORM;

/**
 * @ORM\Entity(repositoryClass="App\Repository\CooperadoRepository")
 */
class Cooperado
{
    /**
     * @ORM\Id()
     * @ORM\GeneratedValue()
     * @ORM\Column(type="integer")
     */
    private $id;

    /**
     * @ORM\Column(type="string", length=100)
     */
    private $nome;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $sexo;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $estadoCivil;

    /**
     * @ORM\Column(type="date")
     */
    private $dataNascimento;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $racaCor;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $necessidadeEspecial;

    /**
     * @ORM\Column(type="string", length=15)
     */
    private $cpf;

    /**
     * @ORM\Column(type="string", length=15)
     */
    private $rg;

    /**
     * @ORM\Column(type="string", length=10)
     */
    private $orgaoExpedidorRg;

    /**
     * @ORM\Column(type="date")
     */
    private $dataExpedicaoRg;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $naturalidade;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $nacionalidade;

    /**
     * @ORM\Column(type="string", length=100, nullable=true)
     */
    private $nomePai;

    /**
     * @ORM\Column(type="string", length=100, nullable=true)
     */
    private $nomeMae;

    /**
     * @ORM\Column(type="float")
     */
    private $rendaFamiliar;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $matricula;

    /**
     * @ORM\ManyToOne(targetEntity="App\Entity\Curso\Curso")
     * @ORM\JoinColumn(nullable=false)
     */
    private $curso;

    /**
     * @ORM\Column(type="string", length=10)
     */
    private $turma;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $escolaridade;

    /**
     * @ORM\Column(type="string", length=100)
     */
    private $rua;

    /**
     * @ORM\Column(type="string", length=100)
     */
    private $bairro;

    /**
     * @ORM\Column(type="string", length=50)
     */
    private $cidade;

    /**
     * @ORM\Column(type="string", length=10)
     */
    private $cep;

    /**
     * @ORM\Column(type="string", length=20)
     */
    private $estado;

    /**
     * @ORM\Column(type="string", length=15, nullable=true)
     */
    private $telefoneResidencial;

    /**
     * @ORM\Column(type="string", length=15)
     */
    private $telefoneCelular;

    /**
     * @ORM\Column(type="string", length=100)
     */
    private $email;

    /**
     * @ORM\Column(type="date")
     */
    private $dataMatricula;

    /**
     * @ORM\Column(type="float")
     */
    private $cotaParte;

    /**
     * @ORM\Column(type="string", length=2)
     * AG: Aguardando
     * AT: Ativo
     * DE: Desligado
     */
    private $status;

    /**
     * @ORM\Column(type="date", nullable=true)
     */
    private $dataDesligamento;

    public function getId(): ?int
    {
        return $this->id;
    }

    public function getNome(): ?string
    {
        return $this->nome;
    }

    public function setNome(string $nome): self
    {
        $this->nome = $nome;

        return $this;
    }

    public function getSexo(): ?string
    {
        return $this->sexo;
    }

    public function setSexo(string $sexo): self
    {
        $this->sexo = $sexo;

        return $this;
    }

    public function getEstadoCivil(): ?string
    {
        return $this->estadoCivil;
    }

    public function setEstadoCivil(string $estadoCivil): self
    {
        $this->estadoCivil = $estadoCivil;

        return $this;
    }

    public function getDataNascimento(): ?\DateTimeInterface
    {
        return $this->dataNascimento;
    }

    public function setDataNascimento(\DateTimeInterface $dataNascimento): self
    {
        $this->dataNascimento = $dataNascimento;

        return $this;
    }

    public function getRacaCor(): ?string
    {
        return $this->racaCor;
    }

    public function setRacaCor(string $racaCor): self
    {
        $this->racaCor = $racaCor;

        return $this;
    }

    public function getNecessidadeEspecial(): ?string
    {
        return $this->necessidadeEspecial;
    }

    public function setNecessidadeEspecial(string $necessidadeEspecial): self
    {
        $this->necessidadeEspecial = $necessidadeEspecial;

        return $this;
    }

    public function getCpf(): ?string
    {
        return $this->cpf;
    }

    public function setCpf(string $cpf): self
    {
        $this->cpf = $cpf;

        return $this;
    }

    public function getRg(): ?string
    {
        return $this->rg;
    }

    public function setRg(string $rg): self
    {
        $this->rg = $rg;

        return $this;
    }

    public function getOrgaoExpedidorRg(): ?string
    {
        return $this->orgaoExpedidorRg;
    }

    public function setOrgaoExpedidorRg(string $orgaoExpedidorRg): self
    {
        $this->orgaoExpedidorRg = $orgaoExpedidorRg;

        return $this;
    }

    public function getDataExpedicaoRg(): ?\DateTimeInterface
    {
        return $this->dataExpedicaoRg;
    }

    public function setDataExpedicaoRg(\DateTimeInterface $dataExpedicaoRg): self
    {
        $this->dataExpedicaoRg = $dataExpedicaoRg;

        return $this;
    }

    public function getNaturalidade(): ?string
    {
        return $this->naturalidade;
    }

    public function setNaturalidade(string $naturalidade): self
    {
        $this->naturalidade = $naturalidade;

        return $this;
    }

    public function getNacionalidade(): ?string
    {
        return $this->nacionalidade;
    }

    public function setNacionalidade(string $nacionalidade): self
    {
        $this->nacionalidade = $nacionalidade;

        return $this;
    }

    public function getNomePai(): ?string
    {
        return $this->nomePai;
    }

    public function setNomePai(?string $nomePai): self
    {
        $this->nomePai = $nomePai;

        return $this;
    }

    public function getNomeMae(): ?string
    {
        return $this->nomeMae;
    }

    public function setNomeMae(?string $nomeMae): self
    {
        $this->nomeMae = $nomeMae;

        return $this;
    }

    public function getRendaFamiliar(): ?float
    {
        return $this->rendaFamiliar;
    }

    public function setRendaFamiliar(float $rendaFamiliar): self
    {
        $this->rendaFamiliar = $rendaFamiliar;

        return $this;
    }

    public function getMatricula(): ?string
    {
        return $this->matricula;
    }

    public function setMatricula(string $matricula): self
    {
        $this->matricula = $matricula;

        return $this;
    }

    public function getCurso(): ?Curso
    {
        return $this->curso;
    }

    public function setCurso(?Curso $curso): self
    {
        $this->curso = $curso;

        return $this;
    }

    public function getTurma(): ?string
    {
        return $this->turma;
    }

    public function setTurma(string $turma): self
    {
        $this->turma = $turma;

        return $this;
    }

    public function getEscolaridade(): ?string
    {
        return $this->escolaridade;
    }

    public function setEscolaridade(string $escolaridade): self
    {
        $this->escolaridade = $escolaridade;

        return $this;
    }

    public function getRua(): ?string
    {
        return $this->rua;
    }

    public function setRua(string $rua): self
    {
        $this->rua = $rua;

        return $this;
    }

    public function getBairro(): ?string
    {
        return $this->bairro;
    }

    public function setBairro(string $bairro): self
    {
        $this->bairro = $bairro;

        return $this;
    }

    public function getCidade(): ?string
    {
        return $this->cidade;
    }

    public function setCidade(string $cidade): self
    {
        $this->cidade = $cidade;

        return $this;
    }

    public function getCep(): ?string
    {
        return $this->cep;
    }

    public function setCep(string $cep): self
    {
        $this->cep = $cep;

        return $this;
    }

    public function getEstado(): ?string
    {
        return $this->estado;
    }

    public function setEstado(string $estado): self
    {
        $this->estado = $estado;

        return $this;
    }

    public function getTelefoneResidencial(): ?string
    {
        return $this->telefoneResidencial;
    }

    public function setTelefoneResidencial(?string $telefoneResidencial): self
    {
        $this->telefoneResidencial = $telefoneResidencial;

        return $this;
    }

    public function getTelefoneCelular(): ?string
    {
        return $this->telefoneCelular;
    }

    public function setTelefoneCelular(string $telefoneCelular): self
    {
        $this->telefoneCelular = $telefoneCelular;

        return $this;
    }

    public function getEmail(): ?string
    {
        return $this->email;
    }

    public function setEmail(string $email): self
    {
        $this->email = $email;

        return $this;
    }

    public function getDataMatricula(): ?\DateTimeInterface
    {
        return $this->dataMatricula;
    }

    public function setDataMatricula(\DateTimeInterface $dataMatricula): self
    {
        $this->dataMatricula = $dataMatricula;

        return $this;
    }

    public function getCotaParte(): ?float
    {
        return $this->cotaParte;
    }

    public function setCotaParte(float $cotaParte): self
    {
        $this->cotaParte = $cotaParte;

        return $this;
    }

    public function getStatus(): ?string
    {
        return $this->status;
    }

    public function setStatus(string $status): self
    {
        $this->status = $status;

        return $this;
    }

    public function getDataDesligamento(): ?\DateTimeInterface
    {
        return $this->dataDesligamento;
    }

    public function setDataDesligamento(?\DateTimeInterface $dataDesligamento): self
    {
        $this->dataDesligamento = $dataDesligamento;

        return $this;
    }
}
