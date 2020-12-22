using System;
using SolarSystem.Enums;
using SolarSystem.Interfces;
using SolarSystem.Models;
using SolarSystem.Modules.Core.Config;
using SolarSystem.Modules.Core.Enums;

namespace SolarSystem.Modules.Core.States
{
    public class MenuAppState : ApplicationState
    {
        protected override void OnChangeState(StackChangeEvent<GameState> evt, IProgressReporter reporter)
        {
            switch (evt.Action)
            {
                case StackAction.Added:
                    AddSceneAction(SceneActionType.Load, AppConfig.MainMenuSceneName);
                    break;
                case StackAction.Removed:
                    AddSceneAction(SceneActionType.Unload, AppConfig.MainMenuSceneName);
                    break;
                case StackAction.Paused:
                    break;
                case StackAction.Resumed:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(evt.Action), evt.Action, null);
            }           
        }
    }
}