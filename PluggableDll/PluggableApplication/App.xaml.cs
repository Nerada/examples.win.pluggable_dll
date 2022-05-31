using System.Windows;

using PluggableDll.PluggableApplication.IOC;

namespace PluggableDll.PluggableApplication
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private async void OnStartup(object sender, StartupEventArgs e)
        {
            var root = new CompositionRoot();
            root.Run();
        }
    }
}
