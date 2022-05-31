using PluggableDll.PluginB.ViewModels;
using PluggableDll.PluginB.Views;
using PluggableDll.PluginCore;

namespace PluggableDll.PluginB.IOC
{
    internal class PluginBCompositionRoot : IPluginRoot
    {
        public PluginBCompositionRoot(PluginConstructorParameters parameters)
        {
            PluginBMainViewModel pluginViewModel = new ();
            PluginBMainView pluginView = new(pluginViewModel);

            ViewModel = pluginViewModel;
            View = pluginView;
        }

        public IPluginViewModel ViewModel { get; }
        public IPluginView View { get; }
    }
}
