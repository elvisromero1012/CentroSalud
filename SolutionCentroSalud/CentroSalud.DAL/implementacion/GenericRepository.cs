using System.Linq.Expressions;
using CentroSalud.DAL.Data;
using CentroSalud.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CentroSalud.DAL.Implementation;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly DbCentroSaludContext _dbContext;

    public GenericRepository(DbCentroSaludContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        try
        {
            _dbContext.Set<TEntity>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
        catch
        {
            throw;
        }
    }

    public async Task<bool> DeleteAsync(TEntity entity)
    {
        try
        {
            _dbContext.Set<TEntity>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        catch
        {
            throw;
        }
    }

    public async Task<IQueryable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filtro = null)
    {
        try
        {
            IQueryable<TEntity> consulta = filtro == null
                ? _dbContext.Set<TEntity>()
                : _dbContext.Set<TEntity>().Where(filtro);

            return await Task.FromResult(consulta);
        }
        catch
        {
            throw;
        }
    }

    public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> filtro)
    {
        try
        {
            return await _dbContext.Set<TEntity>().FirstOrDefaultAsync(filtro);
        }
        catch
        {
            throw;
        }
    }

    public async Task<bool> UpdateAsync(TEntity entity)
    {
        try
        {
            _dbContext.Set<TEntity>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        catch
        {
            throw;
        }
    }
}