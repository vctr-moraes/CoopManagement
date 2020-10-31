using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CoopManagement
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> RecuperarAsync(Guid id);
        Task SalvarAsync(TEntity entity);
        Task ExcluirAsync(TEntity entity);
        Task ExcluirVariosAsync(IEnumerable<TEntity> entities);
    }
}
