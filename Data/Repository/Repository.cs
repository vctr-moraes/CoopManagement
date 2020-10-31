using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoopManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace CoopManagement.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> DbSet;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task ExcluirAsync(TEntity entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task ExcluirVariosAsync(IEnumerable<TEntity> entities)
        {
            _context.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> RecuperarAsync(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public async Task SalvarAsync(TEntity entity)
        {
            var entidadeAntiga = _context.Set<TEntity>().Find(entity.Id);

            if (entidadeAntiga == null)
            {
                _context.Add(entity);
            }
            else
            {
                _context.Entry(entidadeAntiga).State = EntityState.Deleted;
                _context.Update(entity);
            }

            await _context.SaveChangesAsync();
        }
    }
}
