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

            IPluginView? rightPlugin = pluginViews.SingleOrDefault(pv => pv.Location == PluginLocation.Right);

            if (rightPlugin is UIElement rightPluginView)
            {
                _rightPluginLocation.Children.Add(rightPluginView);
            }
        }
    }
}
