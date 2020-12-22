using MikeAssets.ServiceLocator.Bindings.Syntax;

namespace MikeAssets.ServiceLocator.Bindings
{
    public interface IBindingRoot
    {
        IBindingToSyntax<T> Bind<T>();
        IBindingToSyntax<T1, T2> Bind<T1, T2>();
        
        void AddBinding(IBinding binding);
        
        void RemoveBinding(IBinding binding);
    }
}