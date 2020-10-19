namespace SolarSystem.Modules.Core.Interfaces
{
    public interface IReadOnlyServiceLocator
    {
        T Get<T>();
    }
}