using SolarSystem.Modules.GamePlay.Scripts.Configs;

namespace SolarSystem.Modules.GamePlay.Scripts.Static
{
    internal static class GameSettingsExtension
    {
        public static bool IsValid(this GameSettings settings)
        {
            return settings.Player != null;
        }
    }
}