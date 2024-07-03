using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        private readonly AppDbContext _context;

        public StudentController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Student/Index
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        // GET: Student/Input
        public IActionResult Input()
        {
            return View();
        }

        // POST: Student/Input
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Input(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }

        // GET: Student/Details/5
        public IActionResult Details(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }
    }
}