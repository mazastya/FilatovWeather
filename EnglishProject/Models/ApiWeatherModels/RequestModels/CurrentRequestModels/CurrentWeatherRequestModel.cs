using Newtonsoft.Json;

namespace EnglishProject.Models.ApiWeatherModels.RequestModels.CurrentRequestModels;

public class CurrentWeatherRequestModel
{
    [JsonProperty("last_updated_epoch")] public int LastUpdatedEpoch { get; set; }
    [JsonProperty("last_updated")] public string LastUpdated { get; set; }
    [JsonProperty("temp_c")] public decimal TempC { get; set; }
    [JsonProperty("temp_f")] public decimal TempF { get; set; }
    [JsonProperty("is_day")] public int IsDay { get; set; }
    [JsonProperty("condition")] public ConditionModel Condition { get; set; }
    [JsonProperty("wind_mph")] public decimal WindMph { get; set; }
    [JsonProperty("wind_kph")] public decimal WindKph { get; set; }
    [JsonProperty("wind_deg")] public int WindDeg { get; set; }
    [JsonProperty("wind_dir")] public string WindDir { get; set; }
    [JsonProperty("pressure_mb")] public decimal PressureMb { get; set; }
    [JsonProperty("pressure_in")] public decimal PressureIn { get; set; }
    [JsonProperty("precip_mm")] public decimal PrecipMm { get; set; }
    [JsonProperty("precip_in")] public decimal PrecipIn { get; set; }
    [JsonProperty("humidity")] public int Humidity { get; set; }
    [JsonProperty("cloud")] public int Cloud { get; set; }
    [JsonProperty("feelslike_c")] public decimal FeelsLikeC { get; set; }
    [JsonProperty("feelslike_f")] public decimal FeelsLikeF { get; set; }
    [JsonProperty("windchill_c")] public decimal WindChillC { get; set; }
    [JsonProperty("windchill_f")] public decimal WindChillF { get; set; }
    [JsonProperty("heatindex_c")] public decimal HeatIndexC { get; set; }
    [JsonProperty("heatindex_f")] public decimal HeatIndexF { get; set; }
    [JsonProperty("dewpoint_c")] public decimal DewpointC { get; set; }
    [JsonProperty("dewpoint_f")] public decimal DewpointF { get; set; }
    [JsonProperty("vis_km")] public decimal VisKm { get; set; }
    [JsonProperty("vis_miles")] public decimal VisMiles { get; set; }
    [JsonProperty("uv")] public decimal Uv { get; set; }
    [JsonProperty("gust_mph")] public decimal GustMph { get; set; }
    [JsonProperty("gust_kph")] public decimal GustKph { get; set; }
    [JsonProperty("air_quality")] public AirQualityModel? AirQuality { get; set; }
}