using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using WeatherApp.ViewModels;

namespace WeatherApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);

        var textBox = this.FindControl<TextBox>("TextBox");
        textBox.KeyDown += HandleKeyDown;
    }

    private void HandleKeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            var textBox = (TextBox)sender;
            var viewModel = (MainWindowViewModel)DataContext;
            viewModel.DisplayText = textBox.Text;
        }
    }

  
}