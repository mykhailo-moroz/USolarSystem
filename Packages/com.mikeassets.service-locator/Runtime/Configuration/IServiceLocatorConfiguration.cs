using System.Collections.Generic;
using MikeAssets.ServiceLocator.Modules;

namespace SolarSystem.Configuration
{
    public interface IServiceLocatorConfiguration
    {
        void Load(IEnumerable<ILocatorModule> modules);
        void Unload(string name);
        bool HasModule(string name);
    }
}