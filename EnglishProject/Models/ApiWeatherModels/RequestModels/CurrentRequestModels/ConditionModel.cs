using Newtonsoft.Json;

namespace EnglishProject.Models.ApiWeatherModels.RequestModels.CurrentRequestModels;

public class ConditionModel
{
    [JsonProperty("text")] public string Text { get; set; }
    [JsonProperty("icon")] public string Icon { get; set; }
    [JsonProperty("code")] public int Code { get; set; }
}