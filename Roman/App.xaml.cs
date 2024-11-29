using Roman.Models;
namespace Roman;

public partial class App : Application
{
    public static Converter converter;
    public App()
    {
        InitializeComponent();
        converter = new Converter();
        MainPage = new AppShell();
    }
}