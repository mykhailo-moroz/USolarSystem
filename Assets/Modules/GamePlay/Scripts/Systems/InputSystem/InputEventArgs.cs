using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem
{
    public class InputEventArgs : EventArgs
    {
        public Vector2 InputVector { get; }

        public InputEventArgs(Vector2 inputVector)
        {
            InputVector = inputVector;
        }
    }
}