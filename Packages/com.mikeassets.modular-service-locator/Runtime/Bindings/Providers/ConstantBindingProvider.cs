using System;
using System.Linq;

namespace MikeAssets.ModularServiceLocator.Bindings.Providers
{
    public class ConstantBindingProvider : BindingProviderBase
    {
        private readonly object m_service;
        
        public ConstantBindingProvider(object service)
        {
            m_service = service;
        }
        
        public override object ResolveValue(Type contract)
        {
            return Contracts.Contains(contract) ? m_service : null;
        }
    }
}