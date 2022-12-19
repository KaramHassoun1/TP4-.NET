using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP4.Data;
using TP4.Models;
using TP4.Repository;

namespace TP4.Controllers;

public class UniversityController : Controller
{
    [Route("/")]
    [Route("University")]
    public IActionResult Index()
    {
        var unitOfWork = new UnitOfWork(UniversityContext.GetUniversityContextInstance());
        List<string> courses = new  List<string>();
        courses = unitOfWork.Students.GetAllCourses();

        return View(courses);
    }
    [HttpGet]
    [Route("University/{course}")]
    public IActionResult Etudiants(string course)
    {
        var unitOfWork = new UnitOfWork(UniversityContext.GetUniversityContextInstance());
        List<Student> students = new List<Student>();
        students = unitOfWork.Students.GetStudentsByCourse(course);
        ViewBag.students = students;
        ViewBag.course = course;
        return View();
    }
}
