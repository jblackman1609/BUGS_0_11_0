using System.Configuration;
using System.Data;
using System.Windows;
using Bugs.Views;

namespace Bugs;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        AppConfig.Initialize();

        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
    }
}

