using System.Collections.Generic;
using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Input;
using WeatherApp.Models;


namespace WeatherApp.ViewModels;

public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
    private string greeting = "Welcome to the ugliest weather app ever!!";
    private string enteredText;
    private string displayText;
    private string weather;
    private string temperature;
    private string weatherConditionCode;
<<<<<<< HEAD
    private List<DailyForecast> weeklyForecast;
=======
>>>>>>> origin/main


    public string Greeting
    {
        get { return greeting; }
        set
        {
            if (greeting != value)
            {
                greeting = value;
                OnPropertyChanged(nameof(Greeting));
            }
        }
    }

    public string EnteredText
    {
        get { return enteredText; }
        set
        {
            if (enteredText != value)
            {
                enteredText = value;
                OnPropertyChanged(nameof(EnteredText));
            }
        }
    }

    public string DisplayText
    {
        get { return displayText; }
        set
        {
            if (displayText != value)
            {
                displayText = value;
                OnPropertyChanged(nameof(DisplayText));
            }
        }
    }
    
    public string Weather
    {
        get { return weather; }
        set
        {
            if (weather != value)
            {
                weather = value;
                OnPropertyChanged(nameof(Weather));
            }
        }
    }
<<<<<<< HEAD

    private string weather1;
    public string Weather1
    {
        get { return weather1; }
        set
        {
            if (weather1 != value)
            {
                weather1 = value;
                OnPropertyChanged(nameof(Weather1));
            }
        }
    }
    private string weather2;
    public string Weather2
    {
        get { return weather2; }
        set
        {
            if (weather2 != value)
            {
                weather2 = value;
                OnPropertyChanged(nameof(Weather2));
            }
        }
    }
    
    private string weather3;
    public string Weather3
    {
        get { return weather3; }
        set
        {
            if (weather3 != value)
            {
                weather3 = value;
                OnPropertyChanged(nameof(Weather3));
            }
        }
    }
    
    private string weather4;
    public string Weather4
    {
        get { return weather4; }
        set
        {
            if (weather4 != value)
            {
                weather4 = value;
                OnPropertyChanged(nameof(Weather4));
            }
        }
    }
    
    private string weather5;
    public string Weather5
    {
        get { return weather5; }
        set
        {
            if (weather5 != value)
            {
                weather5 = value;
                OnPropertyChanged(nameof(Weather5));
            }
        }
    }
=======
>>>>>>> origin/main
    
    public string Temperature
    {
        get { return temperature; }
        set
        {
            if (temperature != value)
            {
                temperature = value;
                OnPropertyChanged(nameof(Temperature));
            }
        }
    }
    
    public string WeatherConditionCode
    {
        get { return weatherConditionCode; }
        set
        {
            if (weatherConditionCode != value)
            {
                weatherConditionCode = value;
                OnPropertyChanged(nameof(WeatherConditionCode));
            }
        }
    }
    
<<<<<<< HEAD
    public List<DailyForecast> WeeklyForecast
    {
        get { return weeklyForecast; }
        set
        {
            if (weeklyForecast != value)
            {
                weeklyForecast = value;
                OnPropertyChanged(nameof(WeeklyForecast));
            }
        }
    }
=======
>>>>>>> origin/main

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    
    
}