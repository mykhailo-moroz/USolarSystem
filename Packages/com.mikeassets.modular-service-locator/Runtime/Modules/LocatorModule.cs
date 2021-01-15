using UnityEditor;

namespace MikeAssets.ModularServiceLocator
{
    public abstract class LocatorModule
    {
        public abstract void Load();

        public virtual void OnUnload()
        {
            
        }
    }
}