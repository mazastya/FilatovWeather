using System.Diagnostics;
using EnglishProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EnglishProject.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    public IActionResult HomePage()
    {
        logger.LogInformation("HomePage");
        return View();
    }

    public IActionResult Privacy()
    {
        logger.LogInformation("Privacy");
        return View();
    }

    public IActionResult Projects()
    {
        logger.LogInformation("Projects");
        return View();
    }

    public IActionResult Contacts()
    {
        logger.LogInformation("Contacts");
        return View();
    }
    
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        logger.LogInformation("Error");
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}