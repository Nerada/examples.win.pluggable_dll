namespace PluggableDll.PluginCore;

public class PluginConstructorParameters
{
    public PluginConstructorParameters(string sharedPluginVariable)
    {
        SharedPluginVariable = sharedPluginVariable;
    }

    public string SharedPluginVariable { get; }
}