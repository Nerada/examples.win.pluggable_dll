using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PluggableDll.PluginCore;

namespace PluggableDll.PluginA.IOC
{
    public class PluginACompositionRoot : IPluginRoot
    {
        public PluginACompositionRoot(PluginConstructorParameters parameters)
        {

        }

        public IPluginViewModel ViewModel { get; }
        public IPluginView View { get; }
    }
}
