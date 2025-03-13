using Newtonsoft.Json;

namespace EnglishProject.Models.ApiWeatherModels;

public class LocationModel
{
    [JsonProperty("name")] public string Name { get; set; }
    [JsonProperty("region")] public string Region { get; set; }
    [JsonProperty("country")] public string Country { get; set; }
    [JsonProperty("lat")] public decimal Latitude { get; set; }
    [JsonProperty("lon")] public decimal Longitude { get; set; }
    [JsonProperty("tz_id")] public string Timezone { get; set; }
    [JsonProperty("localtime_epoch")] public int LocalTimeEpoch { get; set; }
    [JsonProperty("localtime")] public string LocalTime { get; set; }
}