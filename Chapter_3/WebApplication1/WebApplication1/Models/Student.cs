namespace WebApplication1.Models;

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public uint Age { get; set; }
    public uint Height { get; set; }
    public int Gender { get; set; }
    public string UniversityName { get; set; } = null!;
}