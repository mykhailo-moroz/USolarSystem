using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using MikeAssets.ModularServiceLocator.Interfaces;

namespace MikeAssets.ModularServiceLocator.Bindings.Providers
{
    public abstract class BindingProviderBase : IBindingProvider
    {
        public ConcurrentBag<Type> Contracts { get; }

        public abstract object ResolveValue(Type contract);

        protected BindingProviderBase()
        {
            Contracts = new ConcurrentBag<Type>();
        }
    }
}