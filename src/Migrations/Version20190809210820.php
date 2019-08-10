<?php

declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20190809210820 extends AbstractMigration
{
    public function getDescription() : string
    {
        return '';
    }

    public function up(Schema $schema) : void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('CREATE TABLE cooperado (id INT AUTO_INCREMENT NOT NULL, curso_id INT NOT NULL, nome VARCHAR(100) NOT NULL, sexo VARCHAR(20) NOT NULL, estado_civil VARCHAR(20) NOT NULL, data_nascimento DATE NOT NULL, raca_cor VARCHAR(20) NOT NULL, necessidade_especial VARCHAR(20) NOT NULL, cpf VARCHAR(15) NOT NULL, rg VARCHAR(15) DEFAULT NULL, orgao_expedidor_rg VARCHAR(10) DEFAULT NULL, data_expedicao_rg DATE DEFAULT NULL, naturalidade VARCHAR(20) NOT NULL, nacionalidade VARCHAR(20) NOT NULL, nome_pai VARCHAR(100) DEFAULT NULL, nome_mae VARCHAR(100) DEFAULT NULL, renda_familiar DOUBLE PRECISION NOT NULL, matricula VARCHAR(20) NOT NULL, turma VARCHAR(10) NOT NULL, escolaridade VARCHAR(20) NOT NULL, rua VARCHAR(100) NOT NULL, bairro VARCHAR(100) NOT NULL, cidade VARCHAR(50) NOT NULL, cep VARCHAR(10) NOT NULL, estado VARCHAR(20) NOT NULL, telefone_residencial VARCHAR(15) DEFAULT NULL, telefone_celular VARCHAR(15) NOT NULL, email VARCHAR(100) NOT NULL, data_matricula DATE NOT NULL, cota_parte DOUBLE PRECISION NOT NULL, INDEX IDX_F99DC94287CB4A1F (curso_id), PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('ALTER TABLE cooperado ADD CONSTRAINT FK_F99DC94287CB4A1F FOREIGN KEY (curso_id) REFERENCES curso (id)');
    }

    public function down(Schema $schema) : void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('DROP TABLE cooperado');
    }
}
