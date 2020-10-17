using System;
using System.Collections.Generic;
using SolarSystem.Modules.Core.Kernel.ApplicationState.Interfaces;

namespace SolarSystem.Modules.Core.Kernel.ApplicationState
{
    public class ApplicationStateStack<T> : IApplicationStateStack<T> where T : Enum
    {
        private Stack<IApplicationState<T>> m_applicationStates;
        
        public ApplicationStateStack()
        {
            m_applicationStates = new Stack<IApplicationState<T>>();
        }
        
        public void RegisterState(T key, IApplicationState<T> applicationState)
        {
            
        }
    }
}