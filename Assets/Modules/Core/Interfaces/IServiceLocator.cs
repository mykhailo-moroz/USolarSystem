﻿namespace SolarSystem.Modules.Core.Interfaces
{
    public interface IServiceLocator
    {
        T Get<T>();
    }
}