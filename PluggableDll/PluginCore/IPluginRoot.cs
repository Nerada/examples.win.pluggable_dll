// -----------------------------------------------
//     Author: Ramon Bollen
//      File: PluginCore.IPluginRoot.cs
// Created on: 20220531
// -----------------------------------------------

namespace PluggableDll.PluginCore;

public interface IPluginRoot
{
    // ReSharper disable once UnusedMemberInSuper.Global
    IPluginViewModel ViewModel { get; }
    IPluginView      View      { get; }
}