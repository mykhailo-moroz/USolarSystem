using System;
using SolarSystem.Modules.Core.Abstract;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Modules.Core.Infrastructure;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.States;
using StansAssets.SceneManagement;

namespace SolarSystem.Modules.Core.Static
{
    public static class App
    {
        private static readonly IApplicationStateStack<GameState> s_applicationStateStack = new ApplicationStateStack<GameState>();
        private static readonly IServiceLocator s_serviceLocator = new ServiceLocator();

        public static IReadOnlyServiceLocator Services => s_serviceLocator;
        public static IApplicationStateStack<GameState> State => s_applicationStateStack;
        
        public static void Init(Action onComplete)
        {
            RegisterModule(new CoreModule());

            var preloadService = s_serviceLocator.Get<IPreloadService>();
            preloadService.PreparePreloader(() =>
            {
                InitApplicationStates();
                onComplete.Invoke();
            });
        }

        public static void RegisterModule(ApplicationModule module)
        {
            s_serviceLocator.RegisterModule(module);
        }

        private static void InitApplicationStates()
        {
            s_applicationStateStack.RegisterState(GameState.Menu, new MenuAppState());
            s_applicationStateStack.RegisterState(GameState.Game, new GameAppState());
            s_applicationStateStack.RegisterState(GameState.Pause, new PauseAppState());
        }
    }
}