using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class MyinfoController : Controller
{
    // 
    // GET: /Myinfo/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /Myinfo/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello" + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}