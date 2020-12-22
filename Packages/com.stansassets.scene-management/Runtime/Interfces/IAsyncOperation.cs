using System;

namespace SolarSystem.Interfces
{
    public interface IAsyncOperation
    {
        bool IsDone { get; }
        float Progress { get; }
        event Action<IAsyncOperation> OnComplete;
    }
}
