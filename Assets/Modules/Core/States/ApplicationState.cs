using MikeAssets.ModularServiceLocator.Static;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.Static;
using StansAssets.SceneManagement;

namespace SolarSystem.Modules.Core.States
{
    public abstract class ApplicationState : IApplicationState<GameState>
    {
        readonly SceneActionsQueue m_SceneActionsQueue;

        protected ApplicationState()
        {
            var sceneService = App.Services.Get<ISceneService>();
            m_SceneActionsQueue = new SceneActionsQueue(sceneService);
        }

        protected void AddSceneAction(SceneActionType type, string sceneName)
        {
            m_SceneActionsQueue.AddAction(type, sceneName);
        }
        
        protected abstract void OnChangeState(StackChangeEvent<GameState> evt, IProgressReporter reporter);
        public void ChangeState(StackChangeEvent<GameState> evt, IProgressReporter reporter) {
            OnChangeState(evt, reporter);
            m_SceneActionsQueue.Start(reporter.UpdateProgress, reporter.SetDone);
        }
    }
}