using System;

namespace MikeAssets.ServiceLocator.Bindings
{
    public class Binding : IBinding
    {
        public IBindingConfiguration BindingConfiguration { get; private set; }
        public Type Service { get; private set; }

        public Binding(Type service)
        {
            Service = service;
            BindingConfiguration = new BindingConfiguration();
        }
    }
}