using System.Windows;
using PluggableDll.PluggableApplication.IOC;

namespace PluggableDll.PluggableApplication;

/// <summary>
///     Interaction logic for App.xaml
/// </summary>
public partial class App
{
    private void OnStartup(object sender, StartupEventArgs e)
    {
        CompositionRoot root = new();
        root.Run();
    }
}