using PluggableDll.PluginA.ViewModels;
using PluggableDll.PluginCore;

namespace PluggableDll.PluginA.Views
{
    /// <summary>
    /// Interaction logic for PluginAMainView.xaml
    /// </summary>
    public partial class PluginAMainView : IPluginView
    {
        public PluginAMainView(PluginAMainViewModel pluginAMainViewModel)
        {
            InitializeComponent();

            DataContext = pluginAMainViewModel;
        }

        public PluginLocation Location => PluginLocation.Right;
    }
}
