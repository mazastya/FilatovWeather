using Microsoft.AspNetCore.Mvc;

namespace EnglishProject.Controllers;

public class ProjectsController(ILogger<ProjectsController> logger) : Controller
{
    public IActionResult ApiWeather()
    {
        logger.LogInformation("ApiWeather");
        return View();
    }

    public IActionResult WeatherGame()
    {
        logger.LogInformation("WeatherGame");
        return View();    }
}