using SolarSystem.Editor.IMGUI.Interfaces;
using UnityEngine;

namespace SolarSystem.Editor.IMGUI.SettingsWindow
{
    public abstract class IMGUILayoutElement : ScriptableObject, ILayoutElementIMGUI
    {
        protected Rect m_Position = new Rect();

        public abstract void OnGUI();
        public virtual void OnLayoutEnable() { }
        public virtual void OnAwake() { }

        public void SetPosition(Rect position)
        {
            m_Position = position;
        }
    }
}
