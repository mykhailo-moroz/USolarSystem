using SolarSystem.Editor.Config;
using SolarSystem.Editor.UIToolkit.SettingsWindow;

#if UNITY_2019_4_OR_NEWER
namespace SolarSystem.Editor.UIToolkit.AboutTab
{
    public class AboutTab : BaseTab
    {
        public AboutTab()
            : base($"{PluginsDevKitPackage.UIToolkitPath}/AboutTab/AboutTab")
        {

        }
    }
}
#endif