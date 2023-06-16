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
    

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    
    
}