// -----------------------------------------------
//     Author: Ramon Bollen
//      File: PluginCore.PluginLoader.cs
// Created on: 20220623
// -----------------------------------------------

using System.Reflection;

namespace PluggableDll.PluginCore;

public class PluginLoader
{
    private readonly DirectoryInfo               _pluginPath;
    private readonly PluginConstructorParameters _pluginConstructorParameters;

    public PluginLoader(PluginConstructorParameters pluginConstructorParameters)
    {
        _pluginConstructorParameters = pluginConstructorParameters;

        string  exeFilePath = Assembly.GetExecutingAssembly().Location;
        string? workPath    = Path.GetDirectoryName(exeFilePath);
        _pluginPath = workPath != null ? new DirectoryInfo(workPath) : throw new Exception(@"Cannot find executing directory.");
    }

    public List<IPluginRoot> Load()
    {
        List<IPluginRoot> pluginList = new();

        foreach (FileInfo file in _pluginPath.GetFiles("*.dll"))
        {
            Assembly assembly;

            try { assembly = Assembly.LoadFrom(file.FullName); }
            catch { continue; }

            foreach (ConstructorInfo? constructor in assembly.GetTypes()
                                                             .Where(t => t is {IsClass: true, IsAbstract: false, IsGenericType: false} && typeof(IPluginRoot).IsAssignableFrom(t))
                                                             .Select(type => type.GetConstructor(BindingFlags.Public | BindingFlags.Instance, null, new[] {typeof(PluginConstructorParameters)}, null))
                                                             .Where(constructor => constructor is { }))
            {
                if (constructor?.Invoke(new object[] {_pluginConstructorParameters}) as IPluginRoot is not { } pluginRoot) continue;

                pluginList.Add(pluginRoot);
            }
        }

        return pluginList;
    }
}