using System.Collections.Generic;

namespace WeatherApp.Models;

public class WeeklyForecastData
{
    public List<DailyForecast> DailyForecasts { get; set; }
}