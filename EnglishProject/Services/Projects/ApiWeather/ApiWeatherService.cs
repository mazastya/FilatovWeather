using EnglishProject.Models.ApiWeatherModels;
using Newtonsoft.Json;

namespace EnglishProject.Services.Projects.ApiWeather;

public class ApiWeatherService(HttpClient httpClient, IConfiguration configuration)
{
    private readonly string _apiKey = configuration["ApiWeather:ApiKey"]
                                      ?? throw new InvalidOperationException("API key is not set in the configuration.");

    public async Task<WeatherModel?> GetWeatherAsync(string city, bool airQuality)
    {
        var airQualityString = airQuality ? "yes" : "no";
        var url = $"https://api.weatherapi.com/v1/current.json?key={_apiKey}&q={city}&aqi={airQualityString}";

        try
        {
            var response = await httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Weather API request failed: {response.StatusCode}, Details: {errorMessage}");
            }

            var json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<WeatherModel>(json);
        }
        catch (HttpRequestException ex)
        {
            Console.WriteLine($"HTTP request error: {ex.Message}");
            return null;
        }
        catch (JsonException ex)
        {
            Console.WriteLine($"JSON parsing error: {ex.Message}");
            return null;
        }
    }

}