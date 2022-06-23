namespace PluggableDll.PluginCore;

public class PluginConstructorParameters
{
    public PluginConstructorParameters(string sharedPluginVariable)
    {
        SharedPluginVariable = sharedPluginVariable;
    }

    // ReSharper disable once MemberCanBePrivate.Global - WHY: This would be public in real implementations
    // ReSharper disable once UnusedAutoPropertyAccessor.Global
    public string SharedPluginVariable { get; }
}