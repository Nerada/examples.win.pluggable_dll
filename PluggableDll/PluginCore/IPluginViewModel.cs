namespace PluggableDll.PluginCore;

public interface IPluginViewModel
{
    // ReSharper disable once UnusedMemberInSuper.Global - WHY: Example of something that can be exposed from the plugin
    string PluginName { get; }
}