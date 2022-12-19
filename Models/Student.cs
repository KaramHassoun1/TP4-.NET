using System.ComponentModel.DataAnnotations;

namespace TP4.Models;

public class Student
{
    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; }= null!;
    public string PhoneNumber { get; set; }= null!;
    public string University { get; set; }= null!;
    public DateTime  Timestamp { get; set; }= DateTime.Now;
    public string? Course { get; set; }

}
