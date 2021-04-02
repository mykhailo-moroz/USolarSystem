using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Systems.InputSystem
{
    public delegate void MovingInputEventHandler(object sender, MovingInputEventArgs args);
    public delegate void MousePositionInputEventHandler(object sender, MousePositionInputEventArgs args);
    
    public interface IInputService
    {
        event MovingInputEventHandler OnMovingInput;
        event MousePositionInputEventHandler OnMousePositionChanged;
        
        void AddMovingInput(Vector2 movingVector);

        void AddLookingInput(Vector3 mousePosition);
    }
}