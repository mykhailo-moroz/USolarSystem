using SolarSystem.Editor.Configs;
using UnityEditor;

namespace SolarSystem.BuildConfigurator.Editor
{
    public static class BuildConfigurationMenu
    {
        [MenuItem(SceneManagementPackage.RootMenu + "Build Settings", false, 1)]
        public static void OpenBuildSettings() {
            BuildConfigurationWindow.ShowTowardsInspector("Build Conf");
        }
    }
}
