using PluggableDll.PluginB.ViewModels;
using PluggableDll.PluginCore;

namespace PluggableDll.PluginB.Views;

/// <summary>
///     Interaction logic for PluginBMainView.xaml
/// </summary>
public partial class PluginBMainView : IPluginView
{
    public PluginBMainView(PluginBMainViewModel pluginBMainViewModel)
    {
        InitializeComponent();

        DataContext = pluginBMainViewModel;
    }

    public PluginLocation Location => PluginLocation.Right;
}