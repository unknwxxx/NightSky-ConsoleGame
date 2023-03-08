using NightSky.App.Entities.Spells;
using NightSky.App.Enums;
using NightSky.App.Interfaces;

namespace NightSky.App.Entities
{
    public class Mage : Player
    {
        private float _currentMagicalEnergy;

        private float _maxMagicalEnergy;
        public float CurrentMagicalEnergy
        {
            get => _currentMagicalEnergy;

            set
            {
                if (value > 0)
                    _currentMagicalEnergy = value;
                else
                    throw new ArgumentException("Wrong mana value!");
            }
        }
        public float MaxMagicalEnergy { get => _maxMagicalEnergy; set => _maxMagicalEnergy = value; }
        public Mage() { }
        public Mage(string name, int age, Race race, Gender gender, State state, float maxHealth, float health, bool canTalk,
            bool canMove, bool isInvulnerable, float currentMagicalEnergy, float maxMagicalEnergy) : base(name, age, race, gender, state, maxHealth, health, canTalk, canMove, isInvulnerable)
        {
            _currentMagicalEnergy = currentMagicalEnergy;
            _maxMagicalEnergy = maxMagicalEnergy;
        }
        public override string ToString()
        {
            return base.ToString() + "\n" + $"CurrentMagicalEnergy{CurrentMagicalEnergy}" +
                $"MaxMagicalEnergy{MaxMagicalEnergy}";
        }

    }
}
