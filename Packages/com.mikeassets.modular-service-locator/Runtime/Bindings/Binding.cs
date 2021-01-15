using System;

namespace MikeAssets.ModularServiceLocator.Bindings
{
    public class Binding : IBinding
    {
        public Type Service { get; private set; }
        public IBindingMetadata Metadata { get; private set; }

        public Binding()
        {
            
        }
    }
}