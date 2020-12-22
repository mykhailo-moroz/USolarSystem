using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Static
{
    public static class GameHelper
    {
        public static Quaternion FlipYDirection(this Quaternion rotation)
        {
            var newYDirection = rotation.eulerAngles.y + 180;
            return Quaternion.Euler(rotation.eulerAngles.x, newYDirection, rotation.eulerAngles.z);
        }
    }
}