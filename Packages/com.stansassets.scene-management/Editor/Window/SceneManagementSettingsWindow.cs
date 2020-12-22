#if UNITY_2019_4_OR_NEWER
using SolarSystem.Editor.Configs;
using SolarSystem.Editor.Settings;
using SolarSystem.Editor.UIToolkit.AboutTab;
using SolarSystem.Editor.UIToolkit.SettingsWindow;
using SolarSystem.Editor.Window.Tabs;
using StansAssets.Foundation.Editor;
using UnityEngine;
using UnityEngine.UIElements;
using PackageInfo = UnityEditor.PackageManager.PackageInfo;

namespace SolarSystem.Editor.Window
{
    public class SceneManagementSettingsWindow : PackageSettingsWindow<SceneManagementSettingsWindow>
    {
        protected override PackageInfo GetPackageInfo()
            => PackageManagerUtility.GetPackageInfo(SceneManagementSettings.Instance.PackageName);

        protected override void OnWindowEnable(VisualElement root)
        {
            AddTab("Settings", new SettingsTab());
            AddTab("About", new AboutTab());
        }

        public static GUIContent WindowTitle => new GUIContent(SceneManagementPackage.DisplayName);
    }
}
#endif