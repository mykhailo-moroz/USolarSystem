using System.Collections.Generic;
using MikeAssets.ServiceLocator.Bindings;

namespace MikeAssets.ServiceLocator.Modules
{
    public abstract class LocatorModule : BindingRoot, ILocatorModule
    {
        private readonly List<IBinding> m_bindings;
        
        public string Name { get; private set; }

        protected LocatorModule()
        {
            Name = this.GetType().AssemblyQualifiedName;
            m_bindings = new List<IBinding>();
        }

        public override void AddBinding(Bindings.IBinding binding)
        {
            m_bindings.Add(binding);
        }

        public override void RemoveBinding(IBinding binding)
        {
            m_bindings.Remove(binding);
        }
    }
}