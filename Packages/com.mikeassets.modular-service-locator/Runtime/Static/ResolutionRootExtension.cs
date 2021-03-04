using MikeAssets.ModularServiceLocator.Interfaces;

namespace MikeAssets.ModularServiceLocator.Static
{
    public static class ResolutionRootExtension
    {
        public static T Get<T>(this IResolutionRoot resolutionRoot)
        {
            var service = typeof(T);
            var provider = resolutionRoot.ResolveProvider<T>();
            
            return (T)provider.ResolveValue(service);
        }
    }
}