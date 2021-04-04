namespace SolarSystem.Modules.GamePlay.Scripts.Systems.WeaponSystem
{
    public enum WeaponType
    {
        None = 0,
        Automatic = 1,       // which automatically fire bullets when holding down the shoot button and generally have large magazine sizes
        Semiautomatic = 2,   // which can also fire by holding down the shoot button but generally fire faster by tapping it, and have small magazine sizes
        Charged = 3,         // which need the fire button to be held for a short moment before the release of the projectile (some guns don't need to be charged to shoot, but the uncharged shots deal less damage)
        Beam = 4,            // which are similar to Automatic, except they fire a continuous beam rather than individual bullets
        Burst = 5            // which work like Automatic or Semiautomatic, but fire multiple projectiles and consume multiple ammo in one shot
    }
}