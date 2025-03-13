using EnglishProject.Models.ApiWeatherModels.RequestModels.CurrentRequestModels;
using Newtonsoft.Json;

namespace EnglishProject.Models.ApiWeatherModels;

public class WeatherModel
{
    [JsonProperty("location")] public LocationModel Location { get; set; }
    [JsonProperty("current")] public CurrentWeatherRequestModel Current { get; set; }
}