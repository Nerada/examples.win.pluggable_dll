using System.Collections.Generic;
using System.Linq;
using System.Windows;

using PluggableDll.PluggableApplication.ViewModels;
using PluggableDll.PluginCore;

namespace PluggableDll.PluggableApplication.Views
{
    public partial class MainView : Window
    {
        public MainView(MainViewModel mainViewModel, List<IPluginView> pluginViews)
        {
            InitializeComponent();

            DataContext = mainViewModel;

            List<IPluginView> rightPlugins = pluginViews.Where(pv => pv.Location == PluginLocation.Right).ToList();

            if(rightPlugins.Count > 1) { MessageBox.Show($"Multiple plugins found for the right screen location. Make sure only one is available."); }

            if(rightPlugins.Count == 1 && rightPlugins[0] is UIElement rightPluginView)
            {
                _rightPluginLocation.Children.Add(rightPluginView);
            }
        }
    }
}
