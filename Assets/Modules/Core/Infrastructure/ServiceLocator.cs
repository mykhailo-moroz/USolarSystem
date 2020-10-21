using Ninject;
using SolarSystem.Modules.Core.Abstract;
using SolarSystem.Modules.Core.Interfaces;

namespace SolarSystem.Modules.Core.Infrastructure
{
    internal class ServiceLocator : IServiceLocator
    {
        private readonly IKernel m_kernel;
        
        public ServiceLocator()
        {
            m_kernel = new StandardKernel();
        }
        
        public TInterface Get<TInterface>()
        {
            return m_kernel.Get<TInterface>();
        }

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            m_kernel.Bind<TInterface>().To<TImplementation>().InSingletonScope();
        }

        public void RegisterModule(ApplicationModule module)
        {
            m_kernel.Load(module);
        }
    }
}