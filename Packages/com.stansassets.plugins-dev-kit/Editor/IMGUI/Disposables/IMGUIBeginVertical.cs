using System;
using UnityEditor;
using UnityEngine;

namespace SolarSystem.Editor.IMGUI.Disposables
{
    public class IMGUIBeginVertical : IDisposable
    {
        public IMGUIBeginVertical(params GUILayoutOption[] layoutOptions)
        {
            EditorGUILayout.BeginVertical(layoutOptions);
        }

        public IMGUIBeginVertical(GUIStyle style, params GUILayoutOption[] layoutOptions)
        {
            EditorGUILayout.BeginVertical(style, layoutOptions);
        }

        public void Dispose()
        {
            EditorGUILayout.EndVertical();
        }
    }
}
