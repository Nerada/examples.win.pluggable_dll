// -----------------------------------------------
//     Author: Ramon Bollen
//      File: PluginB.PluginBCompositionRoot.cs
// Created on: 20220623
// -----------------------------------------------

using PluggableDll.PluginB.ViewModels;
using PluggableDll.PluginB.Views;
using PluggableDll.PluginCore;

namespace PluggableDll.PluginB.IOC;

// ReSharper disable once UnusedType.Global
internal class PluginBCompositionRoot : IPluginRoot
{
    // ReSharper disable once UnusedParameter.Local - WHY: Example of parameter passing to plugin
    public PluginBCompositionRoot(PluginConstructorParameters parameters)
    {
        PluginBMainViewModel pluginViewModel = new();
        PluginBMainView      pluginView      = new(pluginViewModel);

        ViewModel = pluginViewModel;
        View      = pluginView;
    }

    public IPluginViewModel ViewModel { get; }
    public IPluginView      View      { get; }
}