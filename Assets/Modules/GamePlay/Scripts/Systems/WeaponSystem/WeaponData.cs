namespace SolarSystem.Modules.GamePlay.Scripts.Systems.WeaponSystem
{
    public class WeaponData
    {
        private float m_attack;
        private float m_rateOfFire;
        private float m_impact;
        private float m_range;
        private float m_reload;
        private float m_magazine;
        private float m_chargeRate;
        private float m_blastRadius;
        private float m_velocity;
        private int m_inventory;
        private WeaponType m_weaponType;

        public float Attack
        {
            get => m_attack;
            set => m_attack = value;
        }

        public float RateOfFire
        {
            get => m_rateOfFire;
            set => m_rateOfFire = value;
        }

        public float Impact
        {
            get => m_impact;
            set => m_impact = value;
        }

        public float Range
        {
            get => m_range;
            set => m_range = value;
        }

        public float Reload
        {
            get => m_reload;
            set => m_reload = value;
        }

        public float Magazine
        {
            get => m_magazine;
            set => m_magazine = value;
        }

        public float ChargeRate
        {
            get => m_chargeRate;
            set => m_chargeRate = value;
        }

        public float BlastRadius
        {
            get => m_blastRadius;
            set => m_blastRadius = value;
        }

        public float Velocity
        {
            get => m_velocity;
            set => m_velocity = value;
        }

        public WeaponType Type
        {
            get => m_weaponType;
            set => m_weaponType = value;
        }

        public int Inventory
        {
            get => m_inventory;
            set => m_inventory = value;
        }
    }
}