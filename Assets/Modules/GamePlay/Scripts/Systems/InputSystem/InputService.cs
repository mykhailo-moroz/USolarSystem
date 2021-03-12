using SolarSystem.Modules.GamePlay.Scripts.Interfaces;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem
{
    public class InputService : IInputService
    {
        public event MovingInputEventHandler OnMovingInput;

        public void AddMovingInput(Vector2 movingVector)
        {
            OnMovingInput?.Invoke(this, new InputEventArgs(movingVector));
        }
    }
}