using TP4.Models;

namespace TP4.Repository;

public interface IStudentRepository : IRepository<Student>
{
    public List<String> GetAllCourses();
    public List<Student> GetStudentsByCourse(String course);

}
