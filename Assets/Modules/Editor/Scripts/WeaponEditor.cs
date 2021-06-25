using UnityEditor;
using UnityEngine;

namespace SolarSystem.Editor
{
    public class WeaponEditor : EditorWindow
    {
        [MenuItem("Custom/Weapon Editor")]
        private static void ShowWindow()
        {
            var window = GetWindowWithRect<WeaponEditor>(new Rect(0, 0, 210, 120));
            window.titleContent = new GUIContent("Weapon Editor");
            window.Show();
        }

        private void OnGUI()
        {
            GUILayout.BeginHorizontal();
            GUILayout.BeginVertical();
            var listIcon = Resources.Load<Texture2D>("weapon_list_icon");
            if (GUILayout.Button(listIcon, GUILayout.Width(100), GUILayout.Height(100)))
            {
                
            }
            GUILayout.Label("Weapon List");
            GUILayout.EndVertical();
            
            GUILayout.BeginVertical();
            var weaponIcon = Resources.Load<Texture2D>("weapon");
            if (GUILayout.Button(weaponIcon, GUILayout.Width(100), GUILayout.Height(100)))
            {
                CreateWeaponWindow.ShowWindow();
            }
            GUILayout.Label("Add weapon");
            GUILayout.EndVertical();
            GUILayout.EndHorizontal();
        }
    }
}