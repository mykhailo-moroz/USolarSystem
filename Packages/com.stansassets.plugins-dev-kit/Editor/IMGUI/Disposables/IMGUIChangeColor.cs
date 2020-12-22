using System;
using UnityEngine;

namespace SolarSystem.Editor.IMGUI.Disposables
{
    public class IMGUIChangeColor : IDisposable
    {
        Color PreviousColor { get; set; }

        public IMGUIChangeColor(string htmlColor)
        {
            PreviousColor = GUI.color;

            ColorUtility.TryParseHtmlString(htmlColor, out var color);
            GUI.color = color;
        }

        public IMGUIChangeColor(Color newColor)
        {
            PreviousColor = GUI.color;
            GUI.color = newColor;
        }

        public void Dispose()
        {
            GUI.color = PreviousColor;
        }
    }
}
