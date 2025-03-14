using EnglishProject.Models.ApiWeatherModels;
using Newtonsoft.Json;

namespace EnglishProject.Services.Projects.ApiWeather;

public class ApiWeatherService(HttpClient httpClient, IConfiguration configuration)
{
    private readonly string _apiKey = configuration["ApiWeather:ApiKey"]
                                      ?? throw new InvalidOperationException("API key is not set in the configuration.");

    public async Task<WeatherModel> GetWeatherAsync(string city, bool airQuality)
    {
        var airQualityString = airQuality ? "yes" : "no";
        var url = $"https://api.weatherapi.com/v1/current.json?key={_apiKey}&q={city}&aqi={airQualityString}";

        var response = await httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();

        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<WeatherModel>(json) ?? throw new InvalidOperationException();
    }
}