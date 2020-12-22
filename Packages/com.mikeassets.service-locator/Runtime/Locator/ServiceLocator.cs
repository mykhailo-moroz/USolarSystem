using MikeAssets.ServiceLocator.Bindings;
using MikeAssets.ServiceLocator.Modules;
using SolarSystem.Configuration;
using UnityEngine.Assertions;

namespace MikeAssets.ServiceLocator
{
    public class ServiceLocator : BindingRoot, IServiceLocatorKernel
    {
        private readonly IServiceLocatorConfiguration m_configuration;

        public ServiceLocator(IServiceLocatorConfiguration configuration)
        {
            m_configuration = configuration;
        }
        
        public void Load(params ILocatorModule[] modules)
        {
            Assert.IsNotNull(modules);
            m_configuration.Load(modules);
        }

        public void Unload(string name)
        {
            Assert.IsNotNull(name);
            m_configuration.Unload(name);
        }

        public bool HasModule(string name)
        {
            return m_configuration.HasModule(name);
        }

        public override void AddBinding(IBinding binding)
        {
            
        }

        public override void RemoveBinding(IBinding binding)
        {
            
        }
    }
}