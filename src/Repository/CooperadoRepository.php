<?php

namespace App\Repository;

use App\Entity\Cooperado\Cooperado;
use Doctrine\Bundle\DoctrineBundle\Repository\ServiceEntityRepository;
use Symfony\Bridge\Doctrine\RegistryInterface;

/**
 * @method Cooperado|null find($id, $lockMode = null, $lockVersion = null)
 * @method Cooperado|null findOneBy(array $criteria, array $orderBy = null)
 * @method Cooperado[]    findAll()
 * @method Cooperado[]    findBy(array $criteria, array $orderBy = null, $limit = null, $offset = null)
 */
class CooperadoRepository extends ServiceEntityRepository
{
    public function __construct(RegistryInterface $registry)
    {
        parent::__construct($registry, Cooperado::class);
    }

    // /**
    //  * @return Cooperado[] Returns an array of Cooperado objects
    //  */
    /*
    public function findByExampleField($value)
    {
        return $this->createQueryBuilder('c')
            ->andWhere('c.exampleField = :val')
            ->setParameter('val', $value)
            ->orderBy('c.id', 'ASC')
            ->setMaxResults(10)
            ->getQuery()
            ->getResult()
        ;
    }
    */

    /*
    public function findOneBySomeField($value): ?Cooperado
    {
        return $this->createQueryBuilder('c')
            ->andWhere('c.exampleField = :val')
            ->setParameter('val', $value)
            ->getQuery()
            ->getOneOrNullResult()
        ;
    }
    */
}
