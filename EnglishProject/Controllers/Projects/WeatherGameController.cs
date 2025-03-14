using Microsoft.AspNetCore.Mvc;

namespace EnglishProject.Controllers.Projects;

public class WeatherGameController(ILogger<WeatherGameController> logger) : Controller
{
    public IActionResult WeatherGame()
    {
        logger.LogInformation("Weather Game");
        return View("~/Views/Projects/WeatherGame.cshtml");
    }
}