using System;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem
{
    public class MovingInputEventArgs : EventArgs
    {
        public Vector2 InputVector { get; }

        public MovingInputEventArgs(Vector2 inputVector)
        {
            InputVector = inputVector;
        }
    }
}