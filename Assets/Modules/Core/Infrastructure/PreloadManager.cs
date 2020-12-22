using System;
using System.Collections.Generic;
using SolarSystem.Interfces;
using SolarSystem.Models;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Utilities.ApplicationStateStack;

namespace SolarSystem.Modules.Core.Infrastructure
{
    public class PreloadManager : IApplicationStateDelegate<GameState>
    {
        readonly IScenePreloader m_Preloader;
        readonly List<GameState> m_StatesWithPreloaderRequired;

        public PreloadManager(IApplicationStateStack<GameState> stateStack, IScenePreloader preloader)
        {
            m_Preloader = preloader;
            stateStack.AddDelegate(this);

            stateStack.SetPreprocessAction(OnStackPreprocess);
            stateStack.SetPostprocessAction(OnStackPostprocess);
        }

        void OnStackPreprocess(StackOperationEvent<GameState> e, Action onComplete)
        {
            if (e.State.Equals(GameState.Game) || e.State.Equals(GameState.Menu))
            {
                m_Preloader.FadeIn(onComplete.Invoke);
            }
            else
            {
                onComplete.Invoke();
            }
        }

        void OnStackPostprocess(StackOperationEvent<GameState> e, Action onComplete)
        {
            if (e.State.Equals(GameState.Game) || e.State.Equals(GameState.Menu))
            {
                m_Preloader.FadeOut(onComplete.Invoke);
            }
            else
            {
                onComplete.Invoke();
            }
        }

        public void ApplicationStateChanged(StackOperationEvent<GameState> e) { }
        public void OnApplicationStateWillChanged(StackOperationEvent<GameState> e) { }

        public void ApplicationStateChangeProgressChanged(float progress, StackChangeEvent<GameState> e)
        {
            m_Preloader.OnProgress(progress);
        }
    }
}