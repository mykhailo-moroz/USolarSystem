using System;
using SolarSystem.Models;

namespace SolarSystem.Interfces
{
    public interface IApplicationStateDelegate<T> where T : Enum
    {
        void OnApplicationStateWillChanged(StackOperationEvent<T> e);
        void ApplicationStateChangeProgressChanged(float progress, StackChangeEvent<T> e);
        void ApplicationStateChanged(StackOperationEvent<T> e);
    }
}
