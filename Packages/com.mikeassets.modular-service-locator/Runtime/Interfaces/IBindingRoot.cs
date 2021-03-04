using System.Collections.Generic;
using MikeAssets.ModularServiceLocator.Bindings;

namespace MikeAssets.ModularServiceLocator.Interfaces
{
    public interface IBindingRoot
    {
        List<IBinding> Bindings { get; }
        void AddBinding(IBinding binding);
        void RemoveBinding(IBinding binding);

        IBindingBuilder<T> Bind<T>();
        IBindingBuilder<T1, T2> Bind<T1, T2>();

        void Unbind<T>();
        void Unbind<T1, T2>();
    }
}