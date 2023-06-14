using System.ComponentModel;
using Avalonia.Controls;
using Avalonia.Input;


namespace WeatherApp.ViewModels;

public class MainWindowViewModel : ViewModelBase, INotifyPropertyChanged
{
    private string greeting = "Welcome to the ugliest weather app ever!!";
    private string enteredText;
    private string displayText;

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

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
    
    
}