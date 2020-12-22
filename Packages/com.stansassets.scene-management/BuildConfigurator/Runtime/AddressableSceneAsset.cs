using System;

namespace SolarSystem.BuildConfigurator.Runtime
{
    /// <summary>
    /// Class that indicates is scene addressable
    /// </summary>
    [Serializable]
    public class AddressableSceneAsset
    {
        public string Guid;
        public bool Addressable;
    }
}
