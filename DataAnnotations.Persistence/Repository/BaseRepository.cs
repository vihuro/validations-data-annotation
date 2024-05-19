using DataAnnotations.Domain.Interface;
using DataAnnotations.Domain.Models;
using DataAnnotations.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace DataAnnotations.Persistence.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly AppDbContext Context;

        public BaseRepository(AppDbContext context)
        {
            Context = context;
        }


        public T Create(T entity)
        {
            entity.DateCreated = DateTime.UtcNow;
            entity.DateUpdated = DateTime.UtcNow;
            Context.Set<T>().Add(entity);

            return entity;
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public async Task<T> GetByIdAsync(int id, CancellationToken cancellationToken)
        {
            return await Context.Set<T>().Where(x => x.Id == id).FirstOrDefaultAsync(cancellationToken);
        }

        public T Update(T entity)
        {
            entity.DateUpdated = DateTime.UtcNow;
            Context.Set<T>().Update(entity);
            return entity;
        }
    }
}
