using MikeAssets.ServiceLocator.Modules;

namespace MikeAssets.ServiceLocator
{
    public interface IServiceLocatorKernel
    {
        void Load(params ILocatorModule[] modules);

        void Unload(string name);

        bool HasModule(string name);
    }
}