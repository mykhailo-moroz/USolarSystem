using System;

namespace MikeAssets.ServiceLocator.Bindings
{
    public interface IBinding
    {
        IBindingConfiguration BindingConfiguration { get; }
        
        Type Service { get; }
    }
}