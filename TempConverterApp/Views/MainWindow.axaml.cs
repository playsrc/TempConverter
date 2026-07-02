using Avalonia.Controls;

namespace TempConverterApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Celsius_TextChanged(object? sender, TextChangedEventArgs e)
    {
        if (string.IsNullOrEmpty(Celsius.Text) || Celsius.Text == "-")
        {
            Fahreinheit.Text = "";
        }
        else if (double.TryParse(Celsius.Text, out double C))
        {
            var F = C * (9d / 5d) + 32;
            Fahreinheit.Text = F.ToString("0.0");
        }
        else
        {
            Celsius.Text = "0";
            Fahreinheit.Text = "0";
        }
    }
}