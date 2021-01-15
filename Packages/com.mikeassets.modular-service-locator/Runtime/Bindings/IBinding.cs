using System;

namespace MikeAssets.ModularServiceLocator.Bindings
{
    public interface IBinding
    {
        Type Service { get; }
        
        IBindingMetadata Metadata { get; }
    }
}