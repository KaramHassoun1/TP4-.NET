using TP4.Models;

namespace TP4.Repository;

public interface IUnitOfWork : IDisposable
{
    IStudentRepository Students { get; }
    bool Complete();
}
