﻿using System;
using MikeAssets.ModularServiceLocator.Interfaces;
using MikeAssets.ModularServiceLocator.Locator;
using MikeAssets.ModularServiceLocator.Static;
using SolarSystem.Modules.Core.Abstract;
using SolarSystem.Modules.Core.Enums;
using SolarSystem.Modules.Core.Infrastructure;
using SolarSystem.Modules.Core.Interfaces;
using SolarSystem.Modules.Core.States;
using StansAssets.SceneManagement;
using UnityEngine;

namespace SolarSystem.Modules.Core.Static
{
    public static class App
    {
        private static readonly IApplicationStateStack<GameState> s_applicationStateStack = new ApplicationStateStack<GameState>();
        private static readonly IServiceLocator s_serviceLocator = new ServiceLocator();

        public static IServiceLocator Services => s_serviceLocator;
        public static IApplicationStateStack<GameState> State => s_applicationStateStack;
        
        public static void Init(Action onComplete)
        {
            RegisterModule(new CoreModule());

            var preloadService = s_serviceLocator.Get<IPreloadService>();
            preloadService?.PreparePreloader(() =>
            {
                InitApplicationStates();
                var preloader = new PreloadManager(s_applicationStateStack, preloadService.Preloader);
                onComplete.Invoke();
            });
        }

        public static void RegisterModule(ApplicationModule module)
        {
            Debug.Log($"Registering Module {module.Name}");
            s_serviceLocator.RegisterModule(module);
        }

        public static void UnregisterModule(string name)
        {
            Debug.Log($"Unregistering Module {name}");
            s_serviceLocator.UnregisterModule(name);
        }

        private static void InitApplicationStates()
        {
            s_applicationStateStack.RegisterState(GameState.Menu, new MenuAppState());
            s_applicationStateStack.RegisterState(GameState.Game, new GameAppState());
            s_applicationStateStack.RegisterState(GameState.Pause, new PauseAppState());
            s_applicationStateStack.RegisterState(GameState.Exit, new GameExitState());
        }
    }
}