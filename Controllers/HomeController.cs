using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Convert_To_MVC.Models;

namespace Convert_To_MVC.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Blog()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
    public IActionResult Services()
    {
        return View();
    }
    public IActionResult Single()
    {
        return View();
    }

}
