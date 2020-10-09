using System;
using SolarSystem.Modules.Core.Kernel.SceneLoading.Inerfaces;

namespace SolarSystem.Modules.Core.Kernel.SceneLoading.Abstract
{
    public abstract class SceneLoadService
    {
        public void Load(string sceneName, Action<ISceneLoader> onComplete)
        {
            
        }
        
        public void Deactivate(string sceneName, Action<ISceneLoader> onComplete)
        {
            
        }
        
        public void Unload(string sceneName, Action<ISceneLoader> onComplete)
        {
            
        }
    }
}