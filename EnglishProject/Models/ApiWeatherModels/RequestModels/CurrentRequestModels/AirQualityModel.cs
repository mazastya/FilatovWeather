using Newtonsoft.Json;

namespace EnglishProject.Models.ApiWeatherModels.RequestModels.CurrentRequestModels;

public class AirQualityModel
{
    [JsonProperty("co")] public float Co { get; set; }
    [JsonProperty("o3")] public float O3 { get; set; }
    [JsonProperty("no2")] public float No2 { get; set; }
    [JsonProperty("so2")] public float So2 { get; set; }
    [JsonProperty("pm2_5")] public float Pm25 { get; set; }
    [JsonProperty("pm10")] public float Pm10 { get; set; }
    [JsonProperty("us-epa-index")] public int UsEpaIndex { get; set; }
    [JsonProperty("gb-defra-index")] public int GbDelfaIndex { get; set; }
}