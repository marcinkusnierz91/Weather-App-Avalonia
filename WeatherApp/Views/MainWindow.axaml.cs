using System;
<<<<<<< HEAD
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Nodes;
=======
using System.Net.Http;
using System.Text.Json;
>>>>>>> origin/main
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;

<<<<<<< HEAD

=======
>>>>>>> origin/main
using WeatherApp.ViewModels;

using WeatherApp.Models;

namespace WeatherApp.Views;


public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    
    private const string apiKey = "69d0f64763a71447797501363435451b";
    private const string currentWeatherApiUrl = "https://api.openweathermap.org/data/2.5/weather";
<<<<<<< HEAD
    private const string weeklyForecastApiUrl = "https://api.openweathermap.org/data/2.5/forecast";
=======
    // private const string weeklyForecastApiUrl = "https://api.openweathermap.org/data/2.5/forecast";
>>>>>>> origin/main

    private readonly HttpClient httpClient = new HttpClient();
    
    private async Task GetWeatherData(string city)
    {
        try
        {
            var currentWeatherUrl = $"{currentWeatherApiUrl}?q={city}&appid={apiKey}";
            var currentWeatherResponse = await httpClient.GetAsync(currentWeatherUrl);
            currentWeatherResponse.EnsureSuccessStatusCode();

            var currentWeatherJson = await currentWeatherResponse.Content.ReadAsStringAsync();
            var currentWeatherData = JsonSerializer.Deserialize<WeatherData>(currentWeatherJson);
            
            float currentTemperatureCelsius = currentWeatherData.Main.Temp - 273.15f;
            var viewModel = (MainWindowViewModel)DataContext;
            
            viewModel.Weather = $"Weather: {currentWeatherData.Weather[0].Description}";
            viewModel.Temperature = $"Temperature: {currentTemperatureCelsius:F1}°C";
            viewModel.WeatherConditionCode = currentWeatherData.Weather[0].Icon;
            
<<<<<<< HEAD
            // Pobierz tygodniową prognozę pogody
            var weeklyForecastUrl = $"{weeklyForecastApiUrl}?q={city}&appid={apiKey}";
            var weeklyForecastResponse = await httpClient.GetAsync(weeklyForecastUrl);
            weeklyForecastResponse.EnsureSuccessStatusCode();
            var weeklyForecastJson = await weeklyForecastResponse.Content.ReadAsStringAsync();
            
            var weeklyForecastData = JsonSerializer.Deserialize<JsonDocument>(weeklyForecastJson).RootElement;
            
            string serializedData = weeklyForecastData.GetRawText();
            List<string> weatherData = new List<string>();

            for (int i = 0; i < 40; i++)
            {
                
                // Pobranie i-tego obiektu z listy
                var forecastObject = weeklyForecastData.GetProperty("list")[i];

                // Pobranie pola "main" z obiektu
                var mainObject = forecastObject.GetProperty("main");

                // Pobranie pola "temp" z obiektu "main"
                var temp = mainObject.GetProperty("temp").GetDecimal();

                // Pobranie pola "dt_txt"
                var dtTxt = forecastObject.GetProperty("dt_txt").GetString();
                var dtTxtDateTime = DateTime.Parse(dtTxt);
                var dayOfWeek = dtTxtDateTime.DayOfWeek;

                // DateTime.TryParse(dtTxt, out DateTime data);
                if (dtTxt.Contains("12:00"))
                    {
                        var weather = forecastObject.GetProperty("weather");
                        var w1 = weather[0].GetProperty("main").GetString();
                        weatherData.Add($" data {dtTxt} Pogoda: {w1} temperatura: {(temp - (decimal)273.15)} dzien: {dayOfWeek}");
                        
                    }                    
                }
            
            viewModel.Weather1 = weatherData[0];
            viewModel.Weather2 = weatherData[1];
            viewModel.Weather3 = weatherData[2];
            viewModel.Weather4 = weatherData[3];
            viewModel.Weather5 = weatherData[4];

=======
>>>>>>> origin/main
        }
        catch (Exception ex)
        {
            // Obsłuż błędy związane z żądaniem HTTP lub przetwarzaniem JSON.
            Console.WriteLine(ex.Message);
        }
    }

    private async void HandleKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            var textBox = (TextBox)sender;
            await GetWeatherData(textBox.Text);
        }
    }


}