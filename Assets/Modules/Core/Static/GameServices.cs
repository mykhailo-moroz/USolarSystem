using System;

namespace SolarSystem.Modules.Core.Static
{
    public class GameServices
    {
        public static void Init(Action onComplete)
        {
            onComplete.Invoke();
        }
    }
}