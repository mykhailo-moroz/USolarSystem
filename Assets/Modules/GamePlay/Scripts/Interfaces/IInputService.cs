using SolarSystem.Modules.GamePlay.Scripts.Systems.InputSsytem;
using UnityEngine;

namespace SolarSystem.Modules.GamePlay.Scripts.Interfaces
{
    public delegate void MovingInputEventHandler(object sender, InputEventArgs args);
    
    public interface IInputService
    {
        event MovingInputEventHandler OnMovingInput;
        
        void AddMovingInput(Vector2 movingVector);
    }
}