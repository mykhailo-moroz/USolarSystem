using SolarSystem.Modules.GamePlay.Scripts.Systems.WeaponSystem;
using UnityEditor;
using UnityEngine;

namespace SolarSystem.Editor
{
    public class CreateWeaponWindow : EditorWindow
    {
        private string m_name = "Some Weapon";
        private string m_description = "A very powerful weapon!";
        private WeaponRarity m_quality = WeaponRarity.None;
        private WeaponType m_weaponType = WeaponType.None;
        private float m_damage = 0.0f;
        private float m_rateOfFire = 0.0f;
        private float m_shootSpeed = 0.0f;
        private float m_impact = 0.0f;
        private float m_range = 0.0f;
        private float m_reloadTime = 0.0f;
        private float m_chargeRate = 0.0f;
        private int m_inventory = 0;
        private GameObject m_weaponObject;
        
        public static void ShowWindow()
        {
            var window = GetWindow<CreateWeaponWindow>();
            window.titleContent = new GUIContent("Create weapon");
            window.Show();
        }

        private void OnGUI()
        {
            GUILayout.BeginVertical();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Name: ");
            m_name = GUILayout.TextField(m_name);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Description: ");
            m_description = GUILayout.TextArea(m_description);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Quality: ");
            m_quality = (WeaponRarity)EditorGUILayout.EnumPopup(m_quality);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Weapon Type: ");
            m_weaponType = (WeaponType)EditorGUILayout.EnumPopup(m_weaponType);
            GUILayout.EndHorizontal();

            GUI.enabled = m_weaponType != WeaponType.None;

            GUILayout.BeginHorizontal();
            GUILayout.Label("Damage: ");
            m_damage = EditorGUILayout.FloatField(m_damage);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Rate of Fire: ");
            m_rateOfFire = EditorGUILayout.FloatField(m_rateOfFire);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Shoot speed: ");
            m_shootSpeed = EditorGUILayout.FloatField(m_shootSpeed);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Impact: ");
            m_impact = EditorGUILayout.FloatField(m_impact);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Range: ");
            m_range = EditorGUILayout.FloatField(m_range);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Reload Time: ");
            m_reloadTime = EditorGUILayout.FloatField(m_reloadTime);
            GUILayout.EndHorizontal();

            if (m_weaponType == WeaponType.Beam) 
            {
                GUILayout.BeginHorizontal();
                GUILayout.Label("Charge rate: ");
               m_chargeRate = EditorGUILayout.FloatField(m_chargeRate);
               GUILayout.EndHorizontal();
            }

            GUILayout.BeginHorizontal();
            GUILayout.Label("Inventory: ");
            m_inventory = EditorGUILayout.IntField(m_inventory);
            GUILayout.EndHorizontal();
            
            GUILayout.BeginHorizontal();
            GUILayout.Label("Object: ");
            m_weaponObject = (GameObject)EditorGUILayout.ObjectField(m_weaponObject, typeof(GameObject));
            GUILayout.EndHorizontal();

            GUI.enabled = m_weaponType != WeaponType.None && m_quality != WeaponRarity.None;
            if (GUILayout.Button("Create Weapon"))
            {
                
            }
            GUILayout.EndVertical();
        }
    }
}