namespace PluggableDll.PluginCore;

public interface IPluginRoot
{
    IPluginViewModel ViewModel { get; }
    IPluginView View { get; }
}