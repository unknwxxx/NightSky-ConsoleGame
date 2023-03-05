using NightSky.App.Enums;

namespace NightSky.App.Entities
{
    public class Mage : Player
    {
        private float _currentMagicalEnergy;

        private float _maxMagicalEnergy;

        public Mage(string name, int age, Race race, Gender gender, State state, float maxHealth, float health, bool canTalk,
            bool canMove, float currentMagicalEnergy, float maxMagicalEnergy) : base(name, age, race, gender, state, maxHealth, health, canTalk, canMove)
        {
            _currentMagicalEnergy = currentMagicalEnergy;
            _maxMagicalEnergy = maxMagicalEnergy;
        }

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

        public override string ToString()
        {
            return base.ToString() + "\n" + $"CurrentMagicalEnergy: {CurrentMagicalEnergy}\n" +
                $"MaxMagicalEnergy: {MaxMagicalEnergy}";
        }

    }
}
