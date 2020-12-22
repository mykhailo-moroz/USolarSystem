using System;
using System.Collections.Generic;
using System.Linq;
using MikeAssets.ServiceLocator.Modules;
using UnityEngine.Assertions;
using UnityEngine.UIElements;

namespace SolarSystem.Configuration
{
    public class ServiceLocatorConfiguration : IServiceLocatorConfiguration
    {
        private readonly Dictionary<Type, ICollection<IBinding>> m_bindings =  new Dictionary<Type, ICollection<IBinding>>();
        private readonly Dictionary<string, ILocatorModule> m_locatorModules;

        public ServiceLocatorConfiguration() : this(new Dictionary<string, ILocatorModule>())
        {
            
        }

        public ServiceLocatorConfiguration(IEnumerable<ILocatorModule> modules) : this(modules.ToDictionary(mod => mod.Name))
        {
            
        }
        
        public ServiceLocatorConfiguration(Dictionary<string, ILocatorModule> modules)
        {
            m_locatorModules = modules;
        }

        public void Load(IEnumerable<ILocatorModule> modules)
        {
            Assert.IsNotNull(modules);
            var locatorModules = modules.ToList();

            foreach (var module in locatorModules)
            {
                m_locatorModules.Add(module.Name, module);
            }
        }

        public void Unload(string name)
        {
            Assert.IsNotNull(name);
            
            m_locatorModules.Remove(name);
        }

        public bool HasModule(string name)
        {
            Assert.IsNotNull(name);
            
            return m_locatorModules.ContainsKey(name);
        }
    }
}