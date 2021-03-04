using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace MikeAssets.ModularServiceLocator.Interfaces
{
    public interface IBindingProvider
    {
        ConcurrentBag<Type> Contracts { get; }

        object ResolveValue(Type contract);
    }
}