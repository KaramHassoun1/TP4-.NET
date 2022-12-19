using TP4.Data;

namespace TP4.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly UniversityContext context;
    public IStudentRepository Students { get; private set; }
    public UnitOfWork(UniversityContext context)
    {
        this.context = context;
        Students = new StudentRepository(context);
    }
    public bool Complete()
    {
        try
        {
            int result = context.SaveChanges();
            return result > 0;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public void Dispose()
    {
        context.Dispose();
    }
}
