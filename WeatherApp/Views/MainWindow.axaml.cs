using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Avalonia.Controls;
using Avalonia.Input;

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
    // private const string weeklyForecastApiUrl = "https://api.openweathermap.org/data/2.5/forecast";

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