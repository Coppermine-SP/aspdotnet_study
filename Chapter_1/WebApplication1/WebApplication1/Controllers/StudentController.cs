using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers;

public class StudentController : Controller
{
    // GET: Student/Index
    public IActionResult Index()
    {
        return RedirectToAction("Input");
    }
    // GET: Student/Input
    public IActionResult Input()
    {
        return View();
    }
    
    // POST: Student/Input
    [HttpPost]
    public IActionResult Input(Student student)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Info", student);
        }
        return View(student);
    }
    // GET : Student/Info
    public IActionResult Info(Student student)
    {
        return View(student);
    }
    
}