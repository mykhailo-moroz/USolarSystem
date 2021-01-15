using System;
using System.Collections.Generic;
using MikeAssets.ModularServiceLocator.Bindings;

namespace MikeAssets.ModularServiceLocator.Locator
{
    public class ServiceLocator : BindingRoot, IServiceLocator
    {
        private readonly Dictionary<Type, IBinding> m_bindings;

        public ServiceLocator()
        {
            m_bindings = new Dictionary<Type, IBinding>();
        }
        
        public override void AddBinding(IBinding binding)
        {
            m_bindings.Add(binding.Service, binding);
        }

        public override void RemoveBinding(IBinding binding)
        {
            m_bindings.Remove(binding.Service);
        }
    }
}