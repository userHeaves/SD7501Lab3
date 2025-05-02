using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Lab3Demo.Models;

namespace Lab3Demo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public ViewResult Details()
    {
        //String string data
        ViewData["Title"] = "Student Details Page";
        ViewData["Header"] = "Student Details";
        Student student = new Student()
        {
            StudentId = 101,
            Name = "James",
            Branch = "CSE",
            Section = "A",
            Gender = "Male"
        };
        //storing Student Data
        ViewData["Student"] = student;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
