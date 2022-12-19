using Microsoft.EntityFrameworkCore;
using TP4.Models;

namespace TP4.Data;

public class UniversityContext : DbContext

{
    //static private attribute for Singleton
    private static UniversityContext? _universityContextInstance;

    private UniversityContext(DbContextOptions options) : base(options){
    }

    private static UniversityContext Instatiate_UniversityContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<UniversityContext>();
        optionsBuilder.UseSqlite("DataSource=C:\\Projects\\TP4-Habib-Sellami\\University.db");
        return new UniversityContext(optionsBuilder.Options);
    }

    public static UniversityContext GetUniversityContextInstance()
    {
        if (_universityContextInstance == null)
        {
            _universityContextInstance = Instatiate_UniversityContext();
            return _universityContextInstance;
        }
        return _universityContextInstance;
    }
    public DbSet<Student>? Student { get; set; }

}
