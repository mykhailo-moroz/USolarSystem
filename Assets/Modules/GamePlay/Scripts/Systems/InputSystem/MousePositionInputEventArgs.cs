using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem
{
    public class MousePositionInputEventArgs : EventArgs
    {
        public Vector3 MousePosition { get; }
        
        public MousePositionInputEventArgs(Vector3 mousePosition)
        {
            MousePosition = mousePosition;
        }
    }
}