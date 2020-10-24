using SolarSystem.Modules.Core.Abstract;

namespace SolarSystem.Modules.Core.Interfaces
{
    public interface IServiceLocator : IReadOnlyServiceLocator
    {
        void Register<TInterface, TImplementation>() where TImplementation : TInterface;

        void RegisterModule(ApplicationModule module);

        void UnregisterModule(string name);
    }
}