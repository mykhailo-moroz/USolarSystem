using MikeAssets.ServiceLocator.Bindings.Syntax;

namespace MikeAssets.ServiceLocator.Bindings
{
    public abstract class BindingRoot : IBindingRoot
    {
        public IBindingToSyntax<T> Bind<T>()
        {
            throw new System.NotImplementedException();
        }

        public IBindingToSyntax<T1, T2> Bind<T1, T2>()
        {
            throw new System.NotImplementedException();
        }

        public abstract void AddBinding(IBinding binding);
        public abstract void RemoveBinding(IBinding binding);
    }
}