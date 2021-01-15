using System;
using System.Collections.Generic;

namespace MikeAssets.ModularServiceLocator.Bindings
{
    public abstract class BindingRoot
    {
        protected BindingRoot()
        {
            
        }

        public abstract void AddBinding(IBinding binding);

        public abstract void RemoveBinding(IBinding binding);
    }
}