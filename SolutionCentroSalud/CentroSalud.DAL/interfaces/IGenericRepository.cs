using System.Linq.Expressions;

namespace CentroSalud.DAL.Interfaces;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filtro = null);
    Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filtro);
    Task<TEntity> AddAsync(TEntity entity);
    Task<bool> UpdateAsync(TEntity entity);
    Task<bool> DeleteAsync(TEntity entity);
}