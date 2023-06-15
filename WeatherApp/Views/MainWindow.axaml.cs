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
    private const string apiUrl = "https://api.openweathermap.org/data/2.5/weather";

    private readonly HttpClient httpClient = new HttpClient();

    // ...

    private async Task GetWeatherData(string city)
    {
        try
        {
            var url = $"{apiUrl}?q={city}&appid={apiKey}";
            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var weatherData = JsonSerializer.Deserialize<WeatherData>(json);

            var viewModel = (MainWindowViewModel)DataContext;
            
            float temperatureCelsius = weatherData.Main.Temp - 273.15f;
            viewModel.DisplayText = $"Temperature: {temperatureCelsius:F1}°C, Weather: {weatherData.Weather[0].Description}";
            // viewModel.DisplayText = $"Temperature: {weatherData.Main.Temp}°C, Weather: {weatherData.Weather[0].Description}";
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