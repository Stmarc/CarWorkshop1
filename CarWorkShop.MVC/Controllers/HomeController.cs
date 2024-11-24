using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CarWorkShop.MVC.Models;

namespace CarWorkShop.MVC.Controllers;

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
        var model = new List<Person>()
        {

        new Person()
        {
            Firstname = "Jakbub",
            Lastname = "Kozera"
        },
        new Person()
        {
            Firstname = "Adam",
            Lastname = "Ma³ysz"
        }
    };
        return View(model);
    }
    public IActionResult About()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
