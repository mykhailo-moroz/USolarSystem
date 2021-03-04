using System;

namespace MikeAssets.ModularServiceLocator.Bindings.Providers
{
    public class TransientBindingProvider : BindingProviderBase
    {
        public override object ResolveValue(Type contract)
        {
            return new object();
        }
    }
}