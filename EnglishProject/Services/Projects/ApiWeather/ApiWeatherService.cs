using EnglishProject.Models.ApiWeatherModels;
using Newtonsoft.Json;

namespace EnglishProject.Services.Projects.ApiWeather;

public class ApiWeatherService(HttpClient httpClient)
{
    private const string ApiKey = "d8cf6b16af144d4f80c104717252901";
    private readonly HttpClient _httpClient = httpClient;

    public async Task<WeatherModel> GetWeatherAsync(string city, bool airQuality)
    {
        var airQualityString = airQuality ? "yes" : "no";
        var url = $"https://api.weatherapi.com/v1/current.json?key={ApiKey}&q={city}&aqi={airQualityString}";
        
        var response = await _httpClient.GetAsync(url);
        response.EnsureSuccessStatusCode();
        
        var json = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<WeatherModel>(json) ?? throw new InvalidOperationException();
    }
}