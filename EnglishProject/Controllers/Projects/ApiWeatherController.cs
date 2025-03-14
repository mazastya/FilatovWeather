using EnglishProject.Services.Projects.ApiWeather;
using Microsoft.AspNetCore.Mvc;

namespace EnglishProject.Controllers.Projects;

public class ApiWeatherController(ILogger<ApiWeatherController> logger, ApiWeatherService apiWeatherService)
    : Controller
{
    [HttpGet]
    public async Task<IActionResult> GetWeather(string city, string airQuality)
    {
        if (string.IsNullOrEmpty(city) || string.IsNullOrEmpty(airQuality))
        {
            logger.LogError("Null or empty city or air quality");
            ViewBag.ErrorMessage = "Please provide valid inputs for city and air quality.";
            return View("Error");
        }

        var includeAirQuality = airQuality.Equals("yes", StringComparison.OrdinalIgnoreCase);

        try
        {
            var weather = await apiWeatherService.GetWeatherAsync(city, includeAirQuality);
            logger.LogInformation("GetWeather success for city: {City}", city);
            return View("~/Views/Projects/ApiWeather.cshtml", weather);
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Failed to retrieve weather data for city: {City}", city);
            ViewBag.ErrorMessage = "Failed to retrieve weather data. Please try again.";
            return View("Error");
        }
    }
}