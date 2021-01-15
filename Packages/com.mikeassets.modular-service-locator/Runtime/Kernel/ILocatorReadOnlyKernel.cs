namespace MikeAssets.ModularServiceLocator
{
    public interface ILocatorReadOnlyKernel
    {
        T Resolve<T>();

        T Resolve<T>(string tag);
    }
}