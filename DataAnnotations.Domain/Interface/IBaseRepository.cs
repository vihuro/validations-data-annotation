using DataAnnotations.Domain.Models;

namespace DataAnnotations.Domain.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        T Create(T entity);
        T Update(T entity);
        void Delete(T entity);
        Task<T> GetByIdAsync(int id, CancellationToken cancellationToken);
        IQueryable<T> GetAll();
    }
}
