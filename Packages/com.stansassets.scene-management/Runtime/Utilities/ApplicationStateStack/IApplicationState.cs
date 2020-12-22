using System;
using SolarSystem.Interfces;
using SolarSystem.Models;

namespace SolarSystem.Utilities.ApplicationStateStack
{
    public interface IApplicationState<T> where T : Enum
    {
        void ChangeState(StackChangeEvent<T> evt, IProgressReporter reporter);
    }
}
