<?php

    namespace App\Repository;

    use App\Entity\Curso\Curso;
    use Doctrine\Bundle\DoctrineBundle\Repository\ServiceEntityRepository;
    use Doctrine\Common\Persistence\ManagerRegistry;

    class CursoRepository extends ServiceEntityRepository
    {
        public function __construct(ManagerRegistry $registry)
        {
            parent::__construct($registry, Curso::class);
        }
    }
?>