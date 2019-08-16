<?php

declare(strict_types=1);

namespace DoctrineMigrations;

use Doctrine\DBAL\Schema\Schema;
use Doctrine\Migrations\AbstractMigration;

/**
 * Auto-generated Migration: Please modify to your needs!
 */
final class Version20190816025513 extends AbstractMigration
{
    public function getDescription() : string
    {
        return '';
    }

    public function up(Schema $schema) : void
    {
        // this up() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('CREATE TABLE servico (id INT AUTO_INCREMENT NOT NULL, titulo VARCHAR(50) NOT NULL, descricao VARCHAR(200) NOT NULL, data_criacao DATE NOT NULL, status VARCHAR(50) NOT NULL, PRIMARY KEY(id)) DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci ENGINE = InnoDB');
        $this->addSql('ALTER TABLE cooperado CHANGE rg rg VARCHAR(15) NOT NULL, CHANGE orgao_expedidor_rg orgao_expedidor_rg VARCHAR(10) NOT NULL, CHANGE data_expedicao_rg data_expedicao_rg DATE NOT NULL');
    }

    public function down(Schema $schema) : void
    {
        // this down() migration is auto-generated, please modify it to your needs
        $this->abortIf($this->connection->getDatabasePlatform()->getName() !== 'mysql', 'Migration can only be executed safely on \'mysql\'.');

        $this->addSql('DROP TABLE servico');
        $this->addSql('ALTER TABLE cooperado CHANGE rg rg VARCHAR(15) DEFAULT NULL COLLATE utf8mb4_unicode_ci, CHANGE orgao_expedidor_rg orgao_expedidor_rg VARCHAR(10) DEFAULT NULL COLLATE utf8mb4_unicode_ci, CHANGE data_expedicao_rg data_expedicao_rg DATE DEFAULT NULL');
    }
}
