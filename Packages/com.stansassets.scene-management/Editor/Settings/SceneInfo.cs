using System;
using UnityEngine.SceneManagement;

namespace SolarSystem.Editor.Settings
{
    [Serializable]
    class SceneStateInfo
    {
        public string Path;
        public bool WasLoaded;

        public SceneStateInfo(Scene scene)
        {
            Path = scene.path;
            WasLoaded = scene.isLoaded;
        }
    }
}
