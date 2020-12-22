using System;
using UnityEditor;
using UnityEngine;

namespace SolarSystem.Editor.IMGUI.Disposables
{
    public class IMGUIBeginHorizontal : IDisposable
    {
        public IMGUIBeginHorizontal(params GUILayoutOption[] layoutOptions)
        {
            EditorGUILayout.BeginHorizontal(layoutOptions);
        }

        public IMGUIBeginHorizontal(GUIStyle style, params GUILayoutOption[] layoutOptions)
        {
            EditorGUILayout.BeginHorizontal(style, layoutOptions);
        }

        public void Dispose()
        {
            EditorGUILayout.EndHorizontal();
        }
    }
}
