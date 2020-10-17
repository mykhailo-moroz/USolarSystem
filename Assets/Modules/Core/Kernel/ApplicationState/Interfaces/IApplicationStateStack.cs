using System;

namespace SolarSystem.Modules.Core.Kernel.ApplicationState.Interfaces
{
    public interface IApplicationStateStack<T> where T : Enum
    {
        void RegisterState(T key, IApplicationState<T> applicationState);
    }
}