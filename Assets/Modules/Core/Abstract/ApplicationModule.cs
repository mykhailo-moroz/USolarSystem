using Ninject.Modules;
using SolarSystem.Modules.Core.Interfaces;

namespace SolarSystem.Modules.Core.Abstract
{
    public abstract class ApplicationModule : NinjectModule
    {
        public abstract override void Load();
    }
}