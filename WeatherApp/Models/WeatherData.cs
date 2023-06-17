using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WeatherApp.Models;

public class MainData
{
    [JsonPropertyName("temp")]
    public float Temp { get; set; }
}

public class WeatherInfo
{
    [JsonPropertyName("main")]
    public string Description { get; set; }

    [JsonPropertyName("icon")]
    public string Icon { get; set; }
}

public class WeatherData
{
    [JsonPropertyName("main")]
    public MainData Main { get; set; }

    [JsonPropertyName("weather")]
    public List<WeatherInfo> Weather { get; set; }
}