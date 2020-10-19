using SolarSystem.Modules.Core.Enums;
using StansAssets.SceneManagement;

namespace SolarSystem.Modules.Core.States
{
    public abstract class ApplicationState : IApplicationState<GameState>
    {
        private readonly SceneActionsQueue m_sceneActionsQueue;

        protected ApplicationState()
        {
            
        }
        
        protected abstract void OnChangeState(StackChangeEvent<GameState> evt, IProgressReporter reporter);
        
        public void ChangeState(StackChangeEvent<GameState> evt, IProgressReporter reporter)
        {
            OnChangeState(evt, reporter);
            
        }
    }
}