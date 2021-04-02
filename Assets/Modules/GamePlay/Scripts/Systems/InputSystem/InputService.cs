using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSystem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem
{
    public class InputService : IInputService
    {
        public event MovingInputEventHandler OnMovingInput;
        public event MousePositionInputEventHandler OnMousePositionChanged;


        public void AddMovingInput(Vector2 movingVector)
        {
            OnMovingInput?.Invoke(this, new MovingInputEventArgs(movingVector));
        }

        public void AddLookingInput(Vector3 mousePosition)
        {
            OnMousePositionChanged?.Invoke(this,  new MousePositionInputEventArgs(mousePosition));
        }
    }
}