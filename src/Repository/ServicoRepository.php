<?php

namespace App\Repository;

use App\Entity\Servico;
use Doctrine\Bundle\DoctrineBundle\Repository\ServiceEntityRepository;
use Symfony\Bridge\Doctrine\RegistryInterface;

/**
 * @method Servico|null find($id, $lockMode = null, $lockVersion = null)
 * @method Servico|null findOneBy(array $criteria, array $orderBy = null)
 * @method Servico[]    findAll()
 * @method Servico[]    findBy(array $criteria, array $orderBy = null, $limit = null, $offset = null)
 */
class ServicoRepository extends ServiceEntityRepository
{
    public function __construct(RegistryInterface $registry)
    {
        parent::__construct($registry, Servico::class);
    }

    // /**
    //  * @return Servico[] Returns an array of Servico objects
    //  */
    /*
    public function findByExampleField($value)
    {
        return $this->createQueryBuilder('s')
            ->andWhere('s.exampleField = :val')
            ->setParameter('val', $value)
            ->orderBy('s.id', 'ASC')
            ->setMaxResults(10)
            ->getQuery()
            ->getResult()
        ;
    }
    */

    /*
    public function findOneBySomeField($value): ?Servico
    {
        return $this->createQueryBuilder('s')
            ->andWhere('s.exampleField = :val')
            ->setParameter('val', $value)
            ->getQuery()
            ->getOneOrNullResult()
        ;
    }
    */
}
