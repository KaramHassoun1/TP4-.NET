using Microsoft.EntityFrameworkCore;
using TP4.Data;
using TP4.Models;

namespace TP4.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity: class
{
    private readonly UniversityContext context;
    private readonly DbSet<TEntity> dbSet;

    public Repository(UniversityContext context)
    {
        this.context = context;
        this.dbSet = context.Set<TEntity>();
    }

    public void Add(TEntity entity)
    {
        dbSet.Add(entity);
    }

    public void Remove(TEntity entity)
    {
        dbSet.Remove(entity);
    }

    public TEntity Get(int id)
    {
        return dbSet.Find(id);
    }

    public List<TEntity> GetAll()
    {
        return dbSet.ToList();
    }

    public TEntity Find(int id)
    {
        return dbSet.Find(id);
    }
}
