namespace TP4.Repository;

public interface IRepository<TEntity> where TEntity : class

{
    void Add(TEntity entity);
    void Remove(TEntity entity);
    TEntity Get(int id);
    List<TEntity> GetAll();
    TEntity Find(int id);

}
