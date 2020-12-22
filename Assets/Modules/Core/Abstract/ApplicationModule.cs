using Ninject.Modules;

namespace SolarSystem.Modules.Core.Abstract
{
    public abstract class ApplicationModule : NinjectModule
    {
        public abstract override void Load();
    }
}