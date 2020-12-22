namespace SolarSystem.Interfces
{
    public interface IProgressReporter
    {
        void UpdateProgress(float v);
        void SetDone();
    }
}
