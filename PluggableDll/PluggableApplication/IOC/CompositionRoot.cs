using System.Collections.Generic;
using System.Linq;

using PluggableDll.PluggableApplication.ViewModels;
using PluggableDll.PluggableApplication.Views;

using PluggableDll.PluginCore;

namespace PluggableDll.PluggableApplication.IOC
{
    public class CompositionRoot
    {
        public void Run()
        {
            PluginConstructorParameters pluginParams = new("Default Plugin Variable");
            List<IPluginRoot> pluginCompositions = new PluginLoader(pluginParams).Load();

            MainViewModel mainViewModel = new();

            MainView mainView = new(mainViewModel, pluginCompositions.Select(pc => pc.View).ToList());

            mainView.Show();
        }
    }
}
