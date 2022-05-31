using PluggableDll.PluginA.ViewModels;
using PluggableDll.PluginA.Views;
using PluggableDll.PluginCore;

namespace PluggableDll.PluginA.IOC
{
    public class PluginACompositionRoot : IPluginRoot
    {
        public PluginACompositionRoot(PluginConstructorParameters parameters)
        {
            PluginAMainViewModel pluginViewModel = new ();
            PluginAMainView pluginView = new(pluginViewModel);

            ViewModel = pluginViewModel;
            View = pluginView;
        }

        public IPluginViewModel ViewModel { get; }
        public IPluginView View { get; }
    }
}
