// -----------------------------------------------
//     Author: Ramon Bollen
//      File: PluginA.PluginACompositionRoot.cs
// Created on: 20220623
// -----------------------------------------------

using PluggableDll.PluginA.ViewModels;
using PluggableDll.PluginA.Views;
using PluggableDll.PluginCore;

namespace PluggableDll.PluginA.IOC;

// ReSharper disable once UnusedType.Global
public class PluginACompositionRoot : IPluginRoot
{
    // ReSharper disable once UnusedParameter.Local - WHY: Example of parameter passing to plugin
    public PluginACompositionRoot(PluginConstructorParameters parameters)
    {
        PluginAMainViewModel pluginViewModel = new();
        PluginAMainView      pluginView      = new(pluginViewModel);

        ViewModel = pluginViewModel;
        View      = pluginView;
    }

    public IPluginViewModel ViewModel { get; }
    public IPluginView      View      { get; }
}