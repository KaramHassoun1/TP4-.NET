using Microsoft.EntityFrameworkCore;
using TP4.Data;
using TP4.Models;

namespace TP4.Repository;

public class StudentRepository : Repository<Student>,IStudentRepository
{
    private readonly UniversityContext context;
    private readonly DbSet<Student> dbSet;

    public StudentRepository(UniversityContext context):base(context)
    {
        this.context = context;
        this.dbSet = context.Set<Student>();
    }
    public List<String> GetAllCourses()
    {
        return dbSet.Select(s => s.Course).Distinct().ToList();
    }
    public List<Student> GetStudentsByCourse(String course)
    {
        return dbSet.Where(s => s.Course.ToLower() == course.ToLower()).ToList();
    }
}
