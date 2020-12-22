using System;
using SolarSystem.Editor.IMGUI.Disposables;
using SolarSystem.Editor.IMGUI.Styles;
using UnityEditor;
using UnityEngine;

namespace SolarSystem.Editor.IMGUI.SettingsWindow
{
    public class IMGUIWindowBlockWithIndent : IDisposable
    {
        public IMGUIWindowBlockWithIndent(GUIContent header)
        {
            if (header.image != null) header.text = " " + header.text;
            GUILayout.Space(10);
            using (new IMGUIBeginHorizontal())
            {
                GUILayout.Space(10);
                EditorGUILayout.LabelField(header, SettingsWindowStyles.ServiceBlockHeader);
            }

            GUILayout.Space(5);

            EditorGUI.indentLevel++;
        }

        public void Dispose()
        {
            EditorGUI.indentLevel--;
            GUILayout.Space(5);
            EditorGUILayout.BeginVertical(SettingsWindowStyles.SeparationStyle);
            GUILayout.Space(5);
            EditorGUILayout.EndVertical();
        }
    }
}
