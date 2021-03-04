namespace MikeAssets.ModularServiceLocator.Interfaces
{
    public interface IResolutionRoot
    {
        IBindingProvider ResolveProvider<T>();
    }
}