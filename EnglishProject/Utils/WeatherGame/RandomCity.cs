using EnglishProject.Models.WeatherGameModels;

namespace EnglishProject.Utils.WeatherGame;

public class RandomCity(PopularCitiesList popularCitiesList)
{
    private readonly Random _random = new();

    public string GetRandomCity()
    {
        return popularCitiesList.CitiesList[_random.Next(popularCitiesList.CitiesList.Count)];
    }
}